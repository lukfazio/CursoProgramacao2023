using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 12");
            int Mes_Numero = Convert.ToInt32(Console.ReadLine());

            string Mes_string = string.Empty;
            string estacao = string.Empty;

            #region Nome do Mes com IF ELSE
            //Usando IF e ELSE
            //if (Mes_Numero == 1)
            //{
            //    Mes_string = "Janeiro";
            //}
            //else if (Mes_Numero == 2)
            //{
            //    Mes_string = "Feveiro";
            //}
            //else if (Mes_Numero == 3)
            //{
            //    Mes_string = "Março";
            //}
            //else if (Mes_Numero == 4)
            //{
            //    Mes_string = "Abril";
            //}
            //else if (Mes_Numero == 5)
            //{
            //    Mes_string = "Maio";
            //}
            //else if (Mes_Numero == 6)
            //{
            //    Mes_string = "Junho";
            //}
            //else if (Mes_Numero == 7)
            //{
            //    Mes_string = "Julho";
            //}
            //else if (Mes_Numero == 8)
            //{
            //    Mes_string = "Agosto";
            //}
            //else if (Mes_Numero == 9)
            //{
            //    Mes_string = "Setembro";
            //}
            //else if (Mes_Numero == 10)
            //{
            //    Mes_string = "Outubro";
            //}
            //else if (Mes_Numero == 11)
            //{
            //    Mes_string = "Novembro";
            //}
            //else if (Mes_Numero == 12)
            //{
            //    Mes_string = "Dezembro";
            //}
            #endregion

            #region Nome do Mes com Switch Case
            switch (Mes_Numero)
            {
                case 1:
                    {
                        Mes_string = "Janeiro";
                        break;
                    }
                case 2:
                    {
                        Mes_string = "Feveiro";
                        break;
                    }
                case 3:
                    {
                        Mes_string = "Março";
                        break;

                    }
                case 4:
                    {
                        Mes_string = "Abril";
                        break;
                    }
                case 5:
                    {
                        Mes_string = "Maio";
                        break;
                    }
                case 6:
                    {
                        Mes_string = "Junho";
                        break;
                    }
                case 7:
                    {
                        Mes_string = "Julho";
                        break;
                    }
                case 8:
                    {
                        Mes_string = "Agosto";
                        break;
                    }
                case 9:
                    {
                        Mes_string = "Setembro";
                        break;
                    }
                case 10:
                    {
                        Mes_string = "Outubro";
                        break;
                    }
                case 11:
                    {
                        Mes_string = "Novembro";
                        break;
                    }
                case 12:
                    {
                        Mes_string = "Dezembro";
                        break;
                    }
            }
            #endregion

            #region Estacao do Ano com IF ELSE
            //3 4 5   Outono
            //6 7 8   Inverno
            //9 10 11 Primavera
            //12 1 2  Verao
            //Usando If Else
            if (Mes_Numero == 3 
                || Mes_Numero == 4
                || Mes_Numero == 5)
            {
                estacao = "Outono";
            }
            else if (Mes_Numero == 6
                     || Mes_Numero == 7
                     || Mes_Numero == 8)
            {
                estacao = "Inverno";
            }
            else if (Mes_Numero == 9
                     || Mes_Numero == 10
                     || Mes_Numero == 11)
            {
                estacao = "Primavera";
            }
            else if (Mes_Numero == 12
                     || Mes_Numero == 1
                     || Mes_Numero == 2)
            {
                estacao = "Verão";
            }
            #endregion

            #region Estacao do Ano com Switch Case

            switch (Mes_Numero)
            {
                case 1:
                case 2:
                case 12:
                    {
                        estacao = "Verão";
                        break;
                    }   
                case 3:
                case 4:
                case 5:
                    {
                        estacao = "Outono";
                        break;
                    }
                case 6:
                case 7:
                case 8:
                    {
                        estacao = "Inverno";
                        break;
                    }
                case 9:
                case 10:
                case 11:
                    {
                        estacao = "Primavera";
                        break;
                    }
            }

            #endregion

            //if (string.IsNullOrEmpty(Mes_string) && string.IsNullOrEmpty(estacao))
            if (Mes_Numero >= 1 && Mes_Numero <= 12)
            {
                Console.WriteLine($"[{DateTime.Now}] Você escolheu o mês {Mes_string}, que é a estação {estacao}");               
            }
            else
            {
                Console.WriteLine("O mês digitado não é válido!");
            }

        }
    }
}
