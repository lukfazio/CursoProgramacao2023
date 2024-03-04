using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Aula 01

            // Exibindo uma mensagem na tela
            // Acionar o Console, Pedir uma Escrita, Fornecer o que sera ecrito

            //Console.WriteLine("Ola Matheus e Andre, sejam bem vindos!!");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Digite seu nome:");
            //var nome = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Ola, "+ nome +" Seja bem Vindo!!");


            #endregion

            #region Licao Aula 01

            //Ola NOME, voce tem IDADE anos e seu jogo favorito é JOGO
            //Console.WriteLine("Digite seu nome:");
            //var nome = Console.ReadLine();
            //Console.WriteLine("Digite sua idade:");
            //var idade = Console.ReadLine();
            //Console.WriteLine("Digite deu jogo favorito:");
            //var jogo = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Ola " + nome + ", você tem " + idade + " anos e seu jogo favorito é " + jogo);


            #endregion

            #region Exemplo Aula 02

            //Console.WriteLine("Trabalahndo com Variaveis:");
            //Console.WriteLine();

            ////CARACTERES = CHAR

            //Console.WriteLine("Digite um caractere:");
            //string texto_recuperado = Console.ReadLine();
            //char caractere;
            //caractere = texto_recuperado.First();
            //Console.WriteLine("Seu caractere é: " + caractere);

            //Console.WriteLine();

            ////TEXTO = STRING
            //Console.WriteLine("Digite um TEXTO:");
            //string texto; // Declarando var texto
            //texto = Console.ReadLine(); //preenchendo o CONTEUDO da var
            //Console.WriteLine("Conteudo da STRING TEXTO: " + texto); //Recuperar o CONTEUDO da var texto

            //Console.WriteLine();

            ////NUMERO = INT ou LONG
            //Console.WriteLine("Digite um número:");
            //int numero1 = 0; //Declarando valor inicial
            //string texto_numero1 = Console.ReadLine();
            //numero1 = Convert.ToInt32(texto_numero1);

            //Console.WriteLine("Digite outro número:");
            //int numero2;
            //string texto_numero2 = Console.ReadLine();
            //numero2 = Convert.ToInt32(texto_numero2);

            //int resultado = numero1 * numero2;
            //Console.WriteLine("O resultado da multiplicação é: " + resultado);

            ////Lógicos = bool
            //Console.WriteLine("Adivinhe minha senha:");
            //string palpite = Console.ReadLine();
            //string senha = "andre123";

            //bool senhaCorreta = palpite == senha;
            //Console.WriteLine("A senha que voce digitou esta correta? " + senhaCorreta);

            #endregion

            #region Aula 03

            //Console.WriteLine("Digite um dia (1 - 31):");
            //int dia;
            //dia = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite um mês (1 - 12):");
            //int mes;
            //mes = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite um ano:");
            //int ano;
            //ano = Convert.ToInt32(Console.ReadLine());

            ////Modo Antigo (antes do C# 5)
            ////Console.WriteLine("Dia: " + dia + ", Mês: " + mes + ", Ano: " + ano);
            ////Console.WriteLine($"Dia: {dia}, Mês: {mes}, Ano: {ano}");
            //Console.WriteLine();
            //DateTime dataInserida = new DateTime(ano, mes, dia);
            //Console.WriteLine("Data Digitada: " + dataInserida.ToString("dd/MM/yyyy"));

            //DateTime dataAtual = DateTime.Now;
            //Console.WriteLine("Data Atual: " + dataAtual);

            //TimeSpan tempoDecorrido = dataAtual - dataInserida;
            //Console.WriteLine($"Dias de idade: {tempoDecorrido.Days}");
            //Console.WriteLine($"Meses de idade: {tempoDecorrido.Days / 12}");
            //Console.WriteLine($"Anos de idade: {tempoDecorrido.Days / 365.25}");

            Console.WriteLine("DIGITE UM NUMERO:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE OUTRO NUMERO:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numeros iguais? {num1 == num2}");
            Console.WriteLine($"Numeros diferentes? {num1 != num2}");
            Console.WriteLine($"Primero numero é maior? {num1 > num2}");
            Console.WriteLine($"Primeiro numero é menor? {num1 < num2}");
            Console.WriteLine($"Primero numero é maior ou igual? {num1 >= num2}");
            Console.WriteLine($"Primeiro numero é menor ou igual? {num1 <= num2}");

            //Pedir um nome e exibir:
            //Quantas letras tem esse texto?
            //Qual a primeira letra desse texto?
            //Qual a ultima letra desse texto?
            //Quantas palavras compoem esse texto?            
           
            //Pedir um número e informar se ele é par ou impar
            


            #endregion

            Console.WriteLine();
            Console.WriteLine("Final do Programa!!");


        }
    }
}

