using Modelo.TiposCadastro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposServicos
{
    public class AgendaConsultas
    {
        public long AgendaConsultasID { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataAgendamento { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public long MedicoVeterinarioID { get; set; }
        public virtual MedicoVeterinario MedicoVeterinario { get; set; }

        public long ContaClieteID { get; set; }
        public virtual ContaCliente ContaCliente { get; set; }

        public AgendaConsultas()
        {
        }

        public AgendaConsultas(long agendaConsultasID, DateTime dataConsultaMarcada, double preco, string tipo, long animalID, long medicoVeterinarioID, long contaClieteID)
        {
            AgendaConsultasID = agendaConsultasID;
            Data = dataConsultaMarcada;
            DataAgendamento = DateTime.Now;
            Preco = Preco;
            Tipo = tipo;
            AnimalID = animalID;
            MedicoVeterinarioID = medicoVeterinarioID;
            ContaClieteID = contaClieteID;
        }
    }
}
