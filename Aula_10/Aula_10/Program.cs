using Biblioteca_Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa Lucio = new Pessoa();
            Lucio.Nome = "Lucio Fazio";
            Lucio.DataNascimeno = new DateTime(1994, 07, 30);
            Lucio.CPF = 12345678900;
            Lucio.Idade = 28;
            Console.WriteLine(Lucio.GetSaldo());
            Lucio.SetSaldo(1000);
            Console.WriteLine(Lucio.GetSaldo());
            Console.WriteLine($"Pessoa Lucio ToString: \n {Lucio.ToString()}");
            Console.WriteLine(Lucio.Hello());

            Cliente Andre = new Cliente();
            Andre.Nome = "Andre";
            Andre.NumeroCadastro = 100;
            Console.WriteLine($"Clinte ANDRE Tostring: \n {Andre.ToString()}");
            Console.WriteLine(Andre.Hello());


        }
    }
}
