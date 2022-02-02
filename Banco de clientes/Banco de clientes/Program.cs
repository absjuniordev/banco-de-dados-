using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            string opcaoUsuario;
           do
            {
                opcaoUsuario = ObterOpcaoUsuario();

                switch (opcaoUsuario.ToUpper())
                {
                    case "1":
                        cadastroUsuario(1);
                        break;
                    case "2":
                        Console.WriteLine("Em implementação");
                        break;
                    case "3":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcão invalida");
                        Console.ReadLine();
                        break;
                        
                }
                Console.Clear();
            } while (opcaoUsuario.ToUpper() != "3");
        }

        private static string ObterOpcaoUsuario()
        {
            string opcaoUsuario;
            Console.WriteLine("|============-CADASTRO DE USUARIOS-=============|");
            Console.WriteLine("|----------------Seja bem vindo!----------------|");
            Console.WriteLine("|===============================================|");
            Console.Write("O que deseja fazer? \n1 - Cadastrar clientes \n2 - Listar usuario \n3 - Sair \n: ");
            opcaoUsuario = (Console.ReadLine());
            Console.WriteLine("|-----------------------------------------------|");
            return opcaoUsuario;
        }

        
        private static int cadastroUsuario(int contt)
        {
            List<string> nome = new List<string>();
            List<string> enderero = new List<string>();
            List<string> telefone = new List<string>();
            string ind, resp1 = "", resp = "";
            int cont1 = 1, conta = 0;
            do
            {
                Console.Write($"Digite o {cont1}ª nome: ");
                ind = Console.ReadLine();
                nome.Add(ind);
                Console.Write($"Digite o {cont1}ª endereço: ");
                ind = Console.ReadLine();
                enderero.Add(ind);
                Console.Write($"Digite o {cont1}ª telefone: ");
                ind = Console.ReadLine();
                telefone.Add(ind);

                Console.Write("Deseja continuar cadastrando? [s/n]: ");
                resp = Console.ReadLine();
                conta++;
                cont1++;
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
            } while (resp == "s");
          
            Console.WriteLine($"{cont1} Usuarios(s) cadastrado(s).");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Deseja listar o(s) nome(s)? [s/n]");
            resp1 = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            
            if (resp1 == "s")
            {
                string[] arr_sample1 = nome.ToArray();
                string[] arr_sample2 = enderero.ToArray();
                string[] arr_sample3 = telefone.ToArray();
                for (int index = 0; index < conta; index++)
                {
                    System.Console.WriteLine($"Nome:{arr_sample1[index]}\nEndereço:{arr_sample2[index]}\nTelefone:{arr_sample3[index]}");
                    Console.WriteLine("---------------------------------------------");
                }
                Console.ReadLine();
            }
            else Console.WriteLine("Obrigado");
            Console.WriteLine("Pressione ENTER para retornar ao MENU.");
            return contt;
        }

       
    }

}
