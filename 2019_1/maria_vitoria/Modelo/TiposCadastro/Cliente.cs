using System;
using System.Collections.Generic;
using System.Text;
using Modelo.TiposServicos;

namespace Modelo.TiposCadastro
{
    public class Cliente : Endereco
    {
        public long ClienteID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public virtual List<Animal> Animais { get; set; }
        public virtual List<ContaCliente> ContaClientes { get; set; }

        public Cliente()
        {

        }

        public Cliente(long clienteID, string nome, DateTime dataNascimento, string sexo, string cPF, string rG, string email, string telefone, string celular, string rua, string numero, string bairro, string cidade, string estado, string cep)
            : base(rua, numero, bairro, cidade, estado, cep)
        {
            ClienteID = clienteID;
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone = telefone;
            Celular = celular;
        }
    }
}
