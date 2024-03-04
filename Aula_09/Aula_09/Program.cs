using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execComSucesso = false;

            while (execComSucesso == false)
            {
                try
                {
                    Console.WriteLine("Digite um número válido:");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O número digitado foi {numero}");
                    var divisao = 100 / numero;
                    Console.WriteLine($"O resultado da divisão de 100 por {numero} é {divisao}");
                    execComSucesso = true;
                }
                //catch (FormatException e)
                //{
                //    Console.WriteLine("Você não digitou um número válido! Erro:");
                //    Console.WriteLine(e.Message);
                //}
                //catch (DivideByZeroException e)
                //{
                //    Console.WriteLine("Zero não é um valor válido! Erro:");
                //    Console.WriteLine(e.Message);
                //}
                catch (Exception e)
                {
                    Console.WriteLine($"A execução retornou um erro do tipo {e.GetType()}:");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Tente Novamente!");
                    Console.WriteLine();
                    execComSucesso = false;
                }
                finally
                {
                    if (execComSucesso == true)
                    {
                        Console.WriteLine("Fim do nosso código!");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
