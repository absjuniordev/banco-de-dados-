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
                switch (opcaoUsuario)
                {
                    case "1":
                        escolhaComLimite(1);
                        break;
                    case "2":
                        escolhaSemLimite(1);
                        break;
                    case "3":

                        break;
                    case "X":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.ReadLine();
                Console.Clear();
            } while (opcaoUsuario.ToUpper() != "X");
        }

        private static string ObterOpcaoUsuario()
        {
            string opcaoUsuario;
            Console.WriteLine("|============-CADASTRO DE USUARIOS-=============|");
            Console.WriteLine("|----------------Seja bem vindo!----------------|");
            Console.WriteLine("|===============================================|");
            Console.Write("O que deseja fazer? \n1 - Cadastrar clientes de forma limitada \n2 - Cadastrar clientes de forma ilimitada \n3 - Listar usuario \nX - Sair \n: ");
            opcaoUsuario = (Console.ReadLine());
            Console.WriteLine("|-----------------------------------------------|");
            return opcaoUsuario;
        }

        private static int escolhaComLimite(int limiteDesejado)
        {
            Console.Write("Quantos usuarios deseja cadastrar? :");
            limiteDesejado = int.Parse(Console.ReadLine());
            //ira limitar a quantidade de valores a serem inseridos no vetor
            Console.WriteLine("===================================================");
            string[,] item = new string[limiteDesejado, 3];
            //classe ||variavel de referencia|| alocação de espaço na memoria

            string nome, telefone, endereço, respostaUsurario = "";
            int cont2 = 1;

            for (int cont = 0; cont < limiteDesejado; cont++)
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();
                item[cont, 0] = nome;
                Console.Write("Digite o endereço: ");
                endereço = Console.ReadLine();
                item[cont, 1] = endereço;
                Console.Write($"Digite o telefone: ");
                telefone = Console.ReadLine();
                item[cont, 2] = telefone;
                cont2++;
                Console.Clear();
                Console.WriteLine("==============================================");
            }
            Console.WriteLine("|Deseja verificar os clientes cadastados? [s/n]|");
            respostaUsurario = Console.ReadLine();
            switch (respostaUsurario)
            {
                case "s":
                    for (int cont1 = 0; cont1 < limiteDesejado; cont1++)
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine($"Cadastro Nº {cont2}\nNome:{item[cont1, 0]}\nEnd:{item[cont1, 1]}\nTel:{item[cont1, 2]} ");
                        Console.WriteLine("-----------------------------------------------------");
                    }
                    break;
                default:
                    Console.WriteLine("Obrigado");
                    break;
            }
            Console.WriteLine("Digite o numeor do cadastro");
            Console.Write("\nDigite o indice que deseja verificar: ");
            int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine($"O indice corresponde ao nome: {[item[num1]}");
            Console.ReadLine();
            return limiteDesejado;
        }

        private static int escolhaSemLimite(int contt)
        {
            List<string> nome = new List<string>();           
            string ind, resp1 = "", resp = "";
            int cont1 = 1, conta = 0;
            do
            {
                Console.Write($"Digite o {cont1}ª nome: ");
                ind = Console.ReadLine();
                nome.Add(ind);
                Console.Write("Deseja continuar? [s/n]: ");
                resp = Console.ReadLine();
                conta++;
                cont1++;
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
            } while (resp == "s");
          
            Console.WriteLine($"Foram cadastrados {cont1} nomes.");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Deseja listar o(s) nome(s)? [s/n]");
            resp1 = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            if (resp1.ToUpper() == "s")
            {
                string[] arr_sample = nome.ToArray();
                for (int index = 0; index < conta; index++)
                {
                    System.Console.WriteLine(arr_sample[index]);
                    Console.WriteLine("---------------------------------------------");
                }
            }
            else Console.WriteLine("Obrigado");
            Console.ReadLine();
            return contt;
        }

       
    }

}
