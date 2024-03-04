using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Auxiliar
{
    public class Pessoa
    {
        public string Nome { get; set; }

        //private int campoNovo;

        //public int CampoNovo
        //{
        //    get 
        //    {
        //        //LOG: Alguem recuperou a minha propriedade!!
        //        return campoNovo; 
        //    }
        //    set 
        //    {
        //        //DISPARAR EMAIL PARA GESTOR: FULANO ESTA TENTANDO ALTERAR O VALOR!
        //        campoNovo = value; 
        //    }
        //}

        public DateTime DataNascimeno;

        public long CPF;

        public string Endereço;

        public long Telefone;

        public int Idade;

        private double Saldo;

        //GET -> Recuperar
        public double GetSaldo()
        {
            return this.Saldo;
        }

        //Set -> Definir
        public void SetSaldo(double valor)
        {
            this.Saldo = valor;
        }

        public void ExibirEndereco()
        {
            Console.WriteLine(this.Endereço);
        }

        public override string ToString()
        {
            return $"Meu nome é {this.Nome}";
        }

        public virtual string Hello()
        {
            return "Olá, eu sou uma Pessoa!";
        }
    }
}
