using Modelo.TiposCadastro;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Servicos
{
    public class ExameServico
    {
        private Controle<Exame> controle;

        public ExameServico()
        {
            controle = new Controle<Exame>();
        }

        public void Salvar(Exame exame)
        {
            controle.Salvar(exame);
        }

        public void Editar(Exame exame)
        {
            controle.Editar(exame);
        }

        public void Excluir(Exame exame)
        {
            controle.Excluir(exame);
        }

        public List<Exame> Obter()
        {
            return controle.Obter("Animal", "MedicoVeterinario");
        }

        public List<Exame> Buscar(Expression<Func<Exame, bool>> exame)
        {
            return controle.Buscar(exame, "Animal", "MedicoVeterinario");
        }
    }
}
