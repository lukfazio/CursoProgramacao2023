using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Solicite ao usuário que digite 5 números, depois exiba os resultados abaixo:
                - Números em ordem Crescente
                - Números em ordem Decrescente
                - Maior número
                - Menor Número
                - Média dos Número (Calculo de média -> Somatória / quantidade) 
             */


            #region Usando_Vetor

            //int contador = 1;
            //int[] numeros = new int[5];

            //while (contador <= numeros.Length)
            //{
            //    //1o numero => posicao 0
            //    //2o numero => posicao 1
            //    //3o numero => posicao 2

            //    Console.WriteLine($"Insira o {contador}o número:");
            //    numeros[contador - 1] = Convert.ToInt32(Console.ReadLine());

            //    contador++;
            //}
            /*
            int[] numeros = new int[5];
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.WriteLine($"Insira o {contador + 1}o número:");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
            }



            Console.WriteLine("Conteudo do vetor antes da ordenação:");
            Console.WriteLine(string.Join(" - ", numeros));

            for (int x = 0; x < numeros.Length; x++)
            {
                for (int y = x + 1; y < numeros.Length; y++)
                {
                    if (numeros[x] > numeros[y])
                    {
                        int aux = numeros[x];
                        numeros[x] = numeros[y];
                        numeros[y] = aux;
                    }
                }
            }

            Console.WriteLine("Conteudo do vetor após da ordenação CRESCENTE:");
            Console.WriteLine(string.Join(" - ", numeros));

            for (int x = 0; x < numeros.Length; x++)
            {
                for (int y = x + 1; y < numeros.Length; y++)
                {
                    if (numeros[x] < numeros[y])
                    {
                        int aux = numeros[x];
                        numeros[x] = numeros[y];
                        numeros[y] = aux;
                    }
                }
            }

            Console.WriteLine("Conteudo do vetor após da ordenação DECRESCENTE:");
            Console.WriteLine(string.Join(" - ", numeros));

            Console.WriteLine($"Maior número é: {numeros[0]}");
            Console.WriteLine($"Menor número é: {numeros[numeros.Length - 1]}");

            int somatoria = 0;
            for (int indice = 0; indice < numeros.Length; indice++)
            {
                somatoria = somatoria + numeros[indice];
            }

            Console.WriteLine($"Somatória = {somatoria}");
            Console.WriteLine($"Média = {somatoria / numeros.Length}");
            */
            #endregion

            #region Usando_Colecoes

            List<int> numerosLista = new List<int>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine($"Insira o {numerosLista.Count + 1}o número ou digite uma letra para finalizar:");
                string entrada = Console.ReadLine();

                int conversao;
                bool conseguiConverter = int.TryParse(entrada, out conversao);
                if (conseguiConverter)
                {
                    numerosLista.Add(conversao);
                }
                else
                {
                    continuar = false;
                    Console.WriteLine("-------------------------------");
                }
            }

            Console.WriteLine("Conteudo da Lista antes da ordenação:");
            Console.WriteLine(string.Join(" - ", numerosLista));
            Console.WriteLine();

            Console.WriteLine($"Maior número é: {numerosLista.Max()}");
            Console.WriteLine($"Menor número é: {numerosLista.Min()}");
            Console.WriteLine();

            numerosLista.Sort();

            Console.WriteLine("Conteudo da Lista após da ordenação CRESCENTE:");
            Console.WriteLine(string.Join(" - ", numerosLista));
            Console.WriteLine();

            numerosLista.Reverse();

            Console.WriteLine("Conteudo da Lista após da ordenação DECRESCENTE:");
            Console.WriteLine(string.Join(" - ", numerosLista));
            Console.WriteLine();

            Console.WriteLine($"Somatória = {numerosLista.Sum()}");
            Console.WriteLine($"Média = {numerosLista.Average()}");


            #endregion

            Console.ReadLine();
        }
    }
}
