using Modelo.TiposServicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposCadastro
{
    public class Animal
    {
        public long AnimalID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }

        public long ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual List<Receita> Receita { get; set; }
        public virtual List<Exame> Exame { get; set; }

        public Animal()
        {

        }

        public Animal(long animalID, string nome, DateTime dataNascimento, string especie, string raca, string sexo, double peso, double tamanho, long clienteID)
        {
            AnimalID = animalID;
            Nome = nome;
            DataNascimento = dataNascimento;
            Especie = especie;
            Raca = raca;
            Sexo = sexo;
            Peso = peso;
            Tamanho = tamanho;
            ClienteID = clienteID;
        }
    }
}
