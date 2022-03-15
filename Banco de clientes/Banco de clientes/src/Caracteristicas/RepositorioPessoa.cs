using Banco_de_clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_clientes
{
    internal class RepositorioPessoa : IRepositorio<Pessoa>
    {
        private List<Pessoa> listaPessoa = new List<Pessoa>();

        public void Atualiza(int id, Pessoa objeto)
        {
            listaPessoa[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaPessoa[id].Excluir();
        }

        public void Insere(Pessoa objeto)
        {
            listaPessoa.Add(objeto);
        }

        public List<Pessoa> Lista()
        {
            return listaPessoa;
        }

        public int ProximoId()
        {
            return listaPessoa.Count;
        }

        public Pessoa RetornaPortaId(int id)
        {
  
            return listaPessoa[id];
        }
    }
}
