using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_clientes
{
    public class MetodosAplicados
    {
        static RepositorioPessoa repositorio = new RepositorioPessoa();

        public static void ListarCadastro()
        {
            Console.WriteLine("Listar Cadastro");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum cadastro Encontrado.");
            }
            foreach (var cadastro in lista)
            {
                Console.WriteLine(cadastro);
            }
        }

        public static void InserirCadastro()
        {
            Console.Write("Digite o Nome completo: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite a Data de Nascimento [dd/mm/aaaa]: ");
            string entradaDataNascimento = Console.ReadLine();

            Console.Write("Digite o seu Sexo [M/F]: ");
            string entradaSexo = Console.ReadLine();

            Console.Write("Digite o seu RG: ");
            string entradaRG = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");
            string entradaCPF = Console.ReadLine();

            Console.Write("Digite o seu Numero de Telefone: ");
            string entradaTelefone = Console.ReadLine();

            Console.Write("Digite o seu Endereço: ");
            string entradaEndereco = Console.ReadLine();

            Console.Write("Digite o CEP: ");
            string entradaCEP = Console.ReadLine();

            Console.Write("Digite o seu Bairro: ");
            string entradaBairro = Console.ReadLine();

            Console.Write("Digite a sua Cidade: ");
            string entradaCidade = Console.ReadLine();

            Console.Write("Digite o seu Estado: ");
            string entradaEstado = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(EstadoCivil)))//ira fazer uma varredura na lista de generos que enumeramos com o Enum
            {//se um novo genero foi add, este codigo não se altera
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(EstadoCivil), i));//imprimirar o nome e o numore correspondente
            }
            Console.WriteLine("Escolha o seu Estado Civil entre as oções acima: ");//entrada
            int entradaEstadoCivil = int.Parse(Console.ReadLine());//capitura

            foreach (int i in Enum.GetValues(typeof(Profissao)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Profissao), i));
            }
            Console.WriteLine("Escolha a sua Profissão entre as oções acima: ");
            int entradaProfissao = int.Parse(Console.ReadLine());

            Pessoa novaPessoa = new Pessoa(id: repositorio.ProximoId(), nome: entradaNome, dataNascimento: entradaDataNascimento, sexo: entradaSexo, rg: entradaRG,
                                           cpf: entradaCPF, telefone: entradaTelefone, endereco: entradaEndereco, cep: entradaCEP, bairro: entradaBairro, cidade: entradaCidade,
                                           estado: entradaEstado, profissao: (Profissao)entradaProfissao, estadoCivil: (EstadoCivil)entradaEstadoCivil);

            repositorio.Insere(novaPessoa);
        }

        public static void AtualizarCadastro()
        {

        }

        public static void ExcluirCadastro()
        {

        }

        public static void VisualizarCadastro()
        {

        }

    }
}
