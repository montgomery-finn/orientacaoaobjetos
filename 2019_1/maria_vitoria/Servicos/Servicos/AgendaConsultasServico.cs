using Modelo.TiposServicos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Servicos
{
    public class AgendaConsultasServico
    {
        private Controle<AgendaConsultas> controle;

        public AgendaConsultasServico()
        {
            controle = new Controle<AgendaConsultas>();
        }

        public void Salvar(AgendaConsultas agendaConsultas)
        {
            controle.Salvar(agendaConsultas);
        }

        public void Editar(AgendaConsultas agendaConsultas)
        {
            controle.Editar(agendaConsultas);
        }

        public void Excluir(AgendaConsultas agendaConsultas)
        {
            controle.Excluir(agendaConsultas);
        }

        public List<AgendaConsultas> Obter()
        {
            return controle.Obter("Animal", "MedicoVeterinario");
        }

        public List<AgendaConsultas> Buscar(Expression<Func<AgendaConsultas, bool>> predicado)
        {
            return controle.Buscar(predicado, "Animal", "MedicoVeterinario");
        }
    }
}
