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
                        WriteLine("Em implementação");
                        break;
                    case "3":
                        WriteLine("Saindo...");
                        break;
                    default:
                        WriteLine("Opcão invalida");
                        ReadLine();
                        break;
                        
                }
                Clear();
            } while (opcaoUsuario.ToUpper() != "3");
        }

        private static string ObterOpcaoUsuario()
        {
            string opcaoUsuario;
            WriteLine("|============-CADASTRO DE USUARIOS-=============|");
            WriteLine("|----------------Seja bem vindo!----------------|");
            WriteLine("|===============================================|");
            Write("O que deseja fazer? \n1 - Cadastrar clientes \n2 - Listar usuario \n3 - Sair \n: ");
            opcaoUsuario = (ReadLine());
            WriteLine("|-----------------------------------------------|");
            return opcaoUsuario;
        }
          
        
        private static int cadastroUsuario(int contt)
        {
            List<string> nome = new List<string>();
            List<string> enderero = new List<string>();
            List<string> telefone = new List<string>();
            string ind, resp1 = "", resp = "";
            int ContadorDeUsuario = 1, TotalUsuario = 0;
            do
            {
                Write($"Digite o {ContadorDeUsuario}ª nome: "); 
                ind = ReadLine();
                nome.Add(ind);
                Write($"Digite o {ContadorDeUsuario}ª endereço: ");
                ind = ReadLine();
                enderero.Add(ind);
                Write($"Digite o {ContadorDeUsuario}ª telefone: ");
                ind = ReadLine();
                telefone.Add(ind);

                Write("Deseja continuar cadastrando? [s/n]: ");
                resp = ReadLine();
                TotalUsuario++;
                ContadorDeUsuario++;
                Clear();
                WriteLine("---------------------------------------------");
            } while (resp == "s");
          
            WriteLine($"{TotalUsuario} Usuarios(s) cadastrado(s).");
            WriteLine("---------------------------------------------");
            Write("Deseja listar o(s) nome(s)? [s/n]");
            resp1 = ReadLine();
            WriteLine("---------------------------------------------");
            
            if (resp1 == "s")
            {
                string[] arr_sample1 = nome.ToArray();
                string[] arr_sample2 = enderero.ToArray();
                string[] arr_sample3 = telefone.ToArray();
                for (int index = 0; index < TotalUsuario; index++)
                {
                    System.Console.WriteLine($"Nome:{arr_sample1[index]}\nEndereço:{arr_sample2[index]}\nTelefone:{arr_sample3[index]}");
                    WriteLine("---------------------------------------------");
                }
                ReadLine();
            }
            else WriteLine("Obrigado");
            WriteLine("Pressione ENTER para retornar ao MENU.");
            return contt;
        }       
    }

}
