
using Banco_de_clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Banco_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntercaoUsuario.Apresentacao();

            var opcaoUsuario = IntercaoUsuario.ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        MetodosAplicados.ListarCadastro();
                        break;
                    case "2":
                        MetodosAplicados.InserirCadastro();
                        break;
                    case "3":
                        MetodosAplicados.AtualizarCadastro();
                        break;
                    case "4":
                        MetodosAplicados.ExcluirCadastro();
                        break;
                    case "5":
                        MetodosAplicados.VisualizarCadastro();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                IntercaoUsuario.Apresentacao();
                opcaoUsuario = IntercaoUsuario.ObterOpcaoUsuario();
            }
        }
    }
}
