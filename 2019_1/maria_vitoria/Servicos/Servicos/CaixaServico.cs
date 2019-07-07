using Modelo.TiposServicos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Servicos
{
    public class CaixaServico
    {
        private Controle<Caixa> controle;

        public CaixaServico()
        {
            controle = new Controle<Caixa>();
        }

        public void Salvar(Caixa caixa)
        {
            controle.Salvar(caixa);
        }

        public void Editar(Caixa caixa)
        {
            controle.Editar(caixa);
        }

        public Double Ultimo()
        {
            Caixa caixa = controle.Ultimo();
            if (caixa != null)
                return caixa.TotalEmCaixa;
            else
                return 0;
        }

        public List<Caixa> Buscar(Expression<Func<Caixa, bool>> predicado)
        {
            return controle.Buscar(predicado, "ContaCliente");
        }
    }
}
