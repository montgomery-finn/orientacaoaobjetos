using Modelo.TiposCadastro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposServicos
{
    public class Receita
    {
        public long ReceitaID { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Tipo { get; set; }
        public string Receitas { get; set; }
        public string Observacoes { get; set; }

        public long MedicoVeterinarioID { get; set; }
        public virtual MedicoVeterinario MedicoVeterinario { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }


        public Receita()
        {
        }

        public Receita(long receitaID, DateTime dataConsulta, string tipo, string receitas, string observacoes, long medicoVeterinarioID, long animalID)
        {
            ReceitaID = receitaID;
            DataConsulta = dataConsulta;
            Tipo = tipo;
            Receitas = receitas;
            Observacoes = observacoes;
            MedicoVeterinarioID = medicoVeterinarioID;
            AnimalID = animalID;
        }
    }
}
