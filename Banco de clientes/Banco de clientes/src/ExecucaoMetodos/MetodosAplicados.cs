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
                var excluido = cadastro.retornaExcluido();//ira pegar o valor F/V pois é booleano
               Console.WriteLine("#ID {0}: - {1} {2}", cadastro.retornaId(), cadastro.retornaNome(), (excluido ? "*Excuildo*" : ""));
                //est arranjo (excluido ? "*Excuildo*" : "") server para verifa se é F/V
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
            Console.Write("Digite o ID do cadastro");
            int indiceCadastro = int.Parse(Console.ReadLine());

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

            Pessoa atualizaPessoa = new Pessoa(id: indiceCadastro, nome: entradaNome, dataNascimento: entradaDataNascimento, sexo: entradaSexo, rg: entradaRG,
                                           cpf: entradaCPF, telefone: entradaTelefone, endereco: entradaEndereco, cep: entradaCEP, bairro: entradaBairro, cidade: entradaCidade,
                                           estado: entradaEstado, profissao: (Profissao)entradaProfissao, estadoCivil: (EstadoCivil)entradaEstadoCivil);

            repositorio.Atualiza(indiceCadastro, atualizaPessoa);
        }

        public static void ExcluirCadastro()
        {
            Console.Write("Digite o id do cadastro: ");
            int indiceCadastro = int.Parse(Console.ReadLine());
            Console.Write("DESEJA REALMENTE EXCLUIR O CADASTRO? [S/N]:");
            char resp = char.Parse(Console.ReadLine().ToUpper());
            if(resp == 'S')
            {
                repositorio.Exclui(indiceCadastro);
            }
            Console.WriteLine();
            return;
            
        }

        public static void VisualizarCadastro()
        {
            Console.Write("Digite o id do cadastro: ");
            int indiceCadastro = int.Parse(Console.ReadLine());

            var cadastro = repositorio.RetornaPortaId(indiceCadastro);
            Console.WriteLine(cadastro);
        }

    }
}
