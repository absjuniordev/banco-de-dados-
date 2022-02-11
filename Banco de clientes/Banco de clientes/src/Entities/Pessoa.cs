using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_clientes.src.Entities
{
    public abstract class Pessoa
    {
        public Pessoa(string Nome, string Endereço, string CEP, int Idade)
        {
            this.Nome = Nome;
            this.CEP = CEP;
            this.Idade = Idade;
            this.Endereço = Endereço;
        }

        public string Nome;
        public string Endereço;
        public string CEP;
        public int Idade;

    }
}
