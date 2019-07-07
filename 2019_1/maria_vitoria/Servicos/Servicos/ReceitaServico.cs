using Modelo.TiposServicos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Servicos
{
    public class ReceitaServico
    {
        private Controle<Receita> controle;

        public ReceitaServico()
        {
            controle = new Controle<Receita>();
        }

        public void Salvar(Receita receita)
        {
            if (receita.ReceitaID == 0)
               controle.Salvar(receita);
        }

        public void Editar(Receita receita)
        {
            controle.Editar(receita);
        }

        public List<Receita> Obter()
        {
            return controle.Obter("Animal", "MedicoVeterinario");
        }

        public List<Receita> Buscar(Expression<Func<Receita, bool>> predicado)
        {
            return controle.Buscar(predicado, "Animal", "MedicoVeterinario");
        }

        public void Excluir(Receita receita)
        {
            controle.Excluir(receita);
        }
    }
}
