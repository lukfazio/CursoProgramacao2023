using System;
using System.Collections.Generic;

namespace Aula_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Revisando...

            /*
             //Entrada e Saida de Dados
            Console.WriteLine("Aqui estou exibindo uma mensagem!");
            string texto_digitado = Console.ReadLine();

            //Variaveis
            string texto = "texto alfanumérico 123456 @@@@@~~%%%###";
            char caractere = 'A';
            int numero_inteiro = 12345;
            long numero_grande = 99999999999;
            decimal numero_monetario = 1.99m;
            bool logicas = true;
            DateTime data = DateTime.Now;
            var texto_2 = "Lucio";
            var numero_2 = 2023;

            //Tomada de decisoes
            if (numero_2 == 2023)
            {
                Console.WriteLine("Você está no Ano correto!");
            }
            else
            {
                Console.WriteLine("Você não está no ano de 2023!");
            }

            switch (numero_2)
            {
                case 2020:
                case 2021:
                case 2022:
                    {
                        Console.WriteLine("Você não está no ano de 2023!");
                        break;
                    }

                case 2023:
                    {
                        Console.WriteLine("Você está no Ano correto!");
                        break;
                    }


                default:
                    {
                        Console.WriteLine("Caiu no Default");
                        break;
                    }
            }
             * */





            #endregion

            #region Vetores
            //string nome = "Andre";
            //string nome2 = "Matheus";
            //string nome3 = "Lucio";
            //Console.WriteLine($"{nome} {nome2} {nome3}...");

            //string[] nomes = new string[4];
            //nomes[0] = "Andre";
            //nomes[1] = "Matheus";
            //nomes[2] = "Lucio";
            //nomes[3] = "Gabriel";

            //nomes[1] = "";

            //Console.WriteLine(string.Join("-",nomes));
            #endregion

            #region Matrizes
            //string[,] batalhaNaval = new string[4, 4];
            //batalhaNaval[1, 1] = "X";
            //batalhaNaval[2, 1] = "X";

            //Console.WriteLine("Digite uma linha:");
            //var linha = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite uma coluna:");
            //var coluna = Convert.ToInt32(Console.ReadLine());

            //if (batalhaNaval[linha,coluna] == "X")
            //{
            //    Console.WriteLine("Voce acertou!");
            //}
            //else
            //{
            //    Console.WriteLine("Tiro na Agua!");
            //}
            #endregion  

            //Coleções

            List<string> nomes= new List<string> ();
            nomes.Add("Fulano");
            nomes.Add("Matheus");
            nomes.Add("Lucio");
            nomes.Add("Andre");

            Console.WriteLine(nomes.Count);
            Console.WriteLine(string.Join(" ", nomes));

            nomes.Remove("Lucio");

            Console.WriteLine(nomes.Count);
            Console.WriteLine(string.Join(" ", nomes));

            nomes.Add("Lucio");

            nomes.Sort();
            Console.WriteLine(string.Join(" ", nomes));

            //nomes.Clear();
            //Console.WriteLine(nomes.Count);

            Console.WriteLine("Lista possui o nome Andre? "+nomes.Contains("Andre"));
            Console.WriteLine("Lista possui o nome Afonso? " + nomes.Contains("Afonso"));


            Console.ReadLine();
        }
    }
}
