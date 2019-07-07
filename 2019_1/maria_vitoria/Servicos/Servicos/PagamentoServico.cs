using Entidades.TiposServicos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Servico.Servicos
{
    public class PagamentoServico
    {
        private Controle<ContaPagar> controle;

        public PagamentoServico()
        {
            controle = new Controle<ContaPagar>();
        }

        public void Salvar(ContaPagar pagar)
        {
            controle.Salvar(pagar);
        }

        public void Editar(ContaPagar pagar)
        {
            controle.Editar(pagar);
        }

        public long Ultimo()
        {
            ContaPagar contaPagar = controle.Ultimo();
            return contaPagar.ContaPagarID;
        }

        public List<ContaPagar> Buscar(Expression<Func<ContaPagar, bool>> predicado)
        {
            return controle.Buscar(predicado, "ContaCliente", "ContaCliente.Cliente");
        }

        public List<ContaPagar> Obter()
        {
            return controle.Obter();
        }

        public bool Existe(Expression<Func<ContaPagar, bool>> predicado)
        {
            return controle.Existe(predicado);
        }
    }
}
