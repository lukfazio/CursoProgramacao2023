using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;
            string opcao = string.Empty;

            while (opcaoValida == false)
            {
                Console.WriteLine("Digite [L] para Ler o arquivo ou [E] para escrever o arquivo:");
                opcao = Console.ReadLine();

                if (!opcao.ToUpper().Equals("E") && !opcao.ToUpper().Equals("L"))
                {
                    Console.WriteLine("Opção Inválida! Tente novamente. \n");
                    opcaoValida = false;
                }
                else
                {
                    opcaoValida = true;
                }
            }

            //Escrita de um arquivo com 1000 linhas de números aleatórios
            if (opcao.ToUpper().Equals("E"))
            {
                string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + "\\Numeros.txt";
                StreamWriter writer = null;

                try
                {
                    writer = new StreamWriter(caminhoArquivo, true);
                    Console.WriteLine("Iniciando a criação do arquivo...");
                    Random rnd = new Random();

                    for (int i = 0; i < 1000; i++)
                    {
                        string mensagem = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fffffff")}] LOG de sistema, o número gerado foi {rnd.Next(0, 99999)}";
                        writer.WriteLine(mensagem);
                    }

                    Console.WriteLine("O Arquivo foi Gerado com Sucesso!");
                    writer.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Sua execução retornou um erro do tipo {ex.GetType()}: \n{ex.Message}");
                }
                finally
                {                    
                    Console.WriteLine("Fim da execução do fonte!");
                    Console.ReadLine();
                }
            }

            //Ler o arquivo
            else if (opcao.ToUpper().Equals("L"))
            {
                string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + "\\Numeros.txt";
                StreamReader reader = null;

                try
                {
                    reader = new StreamReader(caminhoArquivo);
                    string linha = reader.ReadLine();

                    while (linha != null)
                    {
                        Console.WriteLine(linha);

                        linha = reader.ReadLine();
                    }

                    Console.WriteLine("\nLeitura Finalizada!");
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Sua execução retornou um erro do tipo {ex.GetType()}: \n{ex.Message}");
                }
                finally
                {                    
                    Console.WriteLine("Fim da execução do fonte!");
                    Console.ReadLine();
                }

            }            
        }
    }
}
