using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercicio01

            ////Pedir um nome:
            //Console.WriteLine("Digite o seu nome:");
            //string input = Console.ReadLine();

            //Console.WriteLine();//Pulando uma linha

            ////Quantas letras tem esse texto?
            //int qtdd_letras = input.Length; //com espaço
            //string input_sem_espaco = input.Replace(" ", "")
            //                               .Replace(".", "")
            //                               .Replace(",", ""); //Removendo os Espaços, pontos e virgulas
            //Console.WriteLine(input_sem_espaco);
            //qtdd_letras = input_sem_espaco.Length;
            //Console.WriteLine($"O seu nome possui {qtdd_letras} letras!");

            ////Qual a primeira letra desse texto?
            //char primeira_letra = input.FirstOrDefault();
            //Console.WriteLine($"A primeira Letra do seu nome é: {primeira_letra}");

            ////Qual a ultima letra desse texto?
            //char ultima_letra = input.Last();
            ////"LUCIO" => {'L' => 0 , 'U' => 1, 'C' => 2, 'I' => 3, 'O' => 4}
            //string outra_forma_de_ultima_letra = input.Substring(input.Length - 2 , 2);
            //Console.WriteLine($"A última Letra do seu nome é: {ultima_letra} / {outra_forma_de_ultima_letra}");

            ////Quantas palavras compoem esse texto? 
            ////"Lucio dos Santos Fazio" => { "Lucio", "dos", "Santos", "Fazio" }
            //var vetor_palavras = input.Split(' ');
            //int qtddPalavras = vetor_palavras.Length;
            //Console.WriteLine($"O seu nome possui {qtddPalavras} Palavras! Elas são:");
            //Console.WriteLine($"{ string.Join("\n", vetor_palavras) }");

            #endregion

            #region Exercicio02

            //Pedir um número e informar se ele é par ou impar
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            //SE numero divisivel 2 = par          
            if ((numero % 2) == 0) //Executar caso o divisivel_por_dois seja = TRUE
            {
                Console.WriteLine($"O número {numero} é Par!");
            }
            else//SE NAO impar
            {                
                Console.WriteLine($"O número {numero} é Impar!");
            }
                     

            #endregion


            Console.WriteLine("Final da Execução!");
            Console.ReadLine();
        }
    }
}
