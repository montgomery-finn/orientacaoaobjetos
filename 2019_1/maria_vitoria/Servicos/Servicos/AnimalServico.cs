using Modelo.TiposCadastro;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Servicos
{
    public class AnimalServico
    {
        private Controle<Animal> controle;

        public AnimalServico()
        {
            controle = new Controle<Animal>();
        }

        public void Salvar(Animal animal)
        {
            if (animal.AnimalID == 0)
                controle.Salvar(animal);
        }

        public void Editar(Animal animal)
        {
            controle.Editar(animal);
        }

        public void Excluir(Animal animal)
        {
            controle.Excluir(animal);
        }

        public List<Animal> Obter()
        {
            return controle.Obter("Cliente");
        }

        public List<Animal> Buscar(Expression<Func<Animal, bool>> predicado)
        {
            return controle.Buscar(predicado, "Cliente");
        }
    }
}
