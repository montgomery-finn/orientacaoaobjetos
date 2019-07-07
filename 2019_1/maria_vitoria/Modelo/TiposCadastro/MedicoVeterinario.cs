using Modelo.TiposServicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposCadastro
{
    public class MedicoVeterinario : Endereco
    {
        public long MedicoVeterinarioID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CRMV { get; set; }
        public string EstadoCRMV { get; set; }
        public string Especializacao { get; set; }


        public virtual List<Receita> Receitas { get; set; }
        public virtual List<Exame> Exames { get; set; }
        public virtual List<AgendaConsultas> AgendaConsultas { get; set; }

        public MedicoVeterinario()
        {

        }

        public MedicoVeterinario(long medicoVeterinarioID, string nome, DateTime dataNascimento, string sexo, string cPF, string rG, string email, string telefone, string celular, string cRMV, string estadoCRMV, string especializacao, string rua, string numero, string bairro, string cidade, string estado, string cep)
            : base(rua, numero, bairro, cidade, estado, cep)
        {
            MedicoVeterinarioID = medicoVeterinarioID;
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            CRMV = cRMV;
            EstadoCRMV = estadoCRMV;
            Especializacao = especializacao;
        }
    }
}
