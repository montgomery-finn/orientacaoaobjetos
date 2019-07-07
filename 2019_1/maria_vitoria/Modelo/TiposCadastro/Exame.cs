using Modelo.TiposServicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposCadastro
{
    public class Exame
    {
        public long ExameID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataAgendamento { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public long MedicoVeterinarioID { get; set; }
        public virtual MedicoVeterinario MedicoVeterinario { get; set; }

        public long ContaClieteID { get; set; }
        public virtual ContaCliente ContaCliente { get; set; }

        public Exame()
        {

        }

        public Exame(long exameID, string nome, double preco, DateTime dataExame, long animalID, long medicoVeterinarioID, long contaClienteID)
        {
            ExameID = exameID;
            Nome = nome;
            Preco = preco;
            Data = dataExame;
            DataAgendamento = DateTime.Now;
            AnimalID = animalID;
            MedicoVeterinarioID = medicoVeterinarioID;
            ContaClieteID = contaClienteID;
        }
    }
}
