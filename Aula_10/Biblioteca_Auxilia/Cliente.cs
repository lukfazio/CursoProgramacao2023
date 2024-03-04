using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Auxiliar
{
    public class Cliente : Pessoa
    {
        public int NumeroCadastro;

        public bool VIP;

        public override string ToString()
        {
            return $"Meu cadastro é: {this.NumeroCadastro}";
        }

        public override string Hello()
        {
            return "Ola, eu sou um CLIENTE";
        }

    }
}
