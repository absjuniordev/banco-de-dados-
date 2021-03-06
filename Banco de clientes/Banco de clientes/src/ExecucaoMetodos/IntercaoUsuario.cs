using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_clientes
{
    internal class IntercaoUsuario
    {
        public static void Apresentacao()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("| P O R T A L  D E  C A D A S T R O|");
            Console.WriteLine("************************************");
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|    Informe a opção desejada      |");
            Console.WriteLine("|----------------------------------|");

            Console.WriteLine("|1- Listar cadastro                |");
            Console.WriteLine("|2- Inserir novo cadastro          |");
            Console.WriteLine("|3- Atualizar cadastro             |");
            Console.WriteLine("|4- Excluir cadastro               |");
            Console.WriteLine("|5- Visualizar cadastro            |");
            Console.WriteLine("|C- Limpar tela                    |");
            Console.Write(">");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
