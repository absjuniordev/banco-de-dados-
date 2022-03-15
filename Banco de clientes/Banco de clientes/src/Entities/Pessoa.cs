using Banco_de_clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_clientes
{
    public  class Pessoa
    {
        public int Id { get; protected set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Profissao Profissao { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public bool Excluido { get; set; }

        public Pessoa(int id, string nome, string dataNascimento, string sexo, string rg, string cpf, string telefone, string endereco,
                       string cep, string bairro,string cidade, string estado, Profissao profissao, EstadoCivil estadoCivil)
        {
            Id = id;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.RG = rg;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.CEP = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Profissao = profissao;
            this.EstadoCivil = estadoCivil;
            this.Excluido = false;
        }

        public override string ToString()// Isto será referencia n ahora da impressão
        {
            string retorno = "";

            retorno += "Nome completo: " + this.Nome + Environment.NewLine;
            retorno += "Data de Nascimento: " + this.DataNascimento + Environment.NewLine;
            retorno += "Sexo: " + this.Sexo + Environment.NewLine;
            retorno += "RG: " + this.RG + Environment.NewLine;
            retorno += "CPF: " + this.CPF + Environment.NewLine;
            retorno += "Numero do Telfone: " + this.Telefone + Environment.NewLine;
            retorno += "Endereço " + this.Nome + Environment.NewLine;
            retorno += "CEP: " + this.CEP + Environment.NewLine;
            retorno += "Bairro: " + this.Bairro + Environment.NewLine;
            retorno += "Cidade: " + this.Cidade + Environment.NewLine;
            retorno += "Estado: " + this.Estado + Environment.NewLine;
            retorno += "Profissão: " + this.Profissao + Environment.NewLine;
            retorno += "Estado Civil: " + this.EstadoCivil + Environment.NewLine;

            return retorno;
        }

        //Funções
        public string retornaNome()
        {
            return this.Nome;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;

        }
    }
}
