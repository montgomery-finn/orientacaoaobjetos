using Modelo.TiposServicos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Servico.Servicos
{
    public class ContaClienteServico
    {
        private Controle<ContaCliente> controle;

        public ContaClienteServico()
        {
            controle = new Controle<ContaCliente>();
        }

        public void Salvar(ContaCliente contaCliente)
        {
            controle.Salvar(contaCliente);
        }

        public void Editar(ContaCliente contaCliente)
        {
            controle.Editar(contaCliente);
        }

        public long Ultimo()
        {
            ContaCliente contaCliente = controle.Ultimo();
            return contaCliente.ContaClienteID;
        }

        public List<ContaCliente> Buscar(Expression<Func<ContaCliente, bool>> predicado)
        {
            return controle.Buscar(predicado, "Cliente");
        }

        public List<ContaCliente> Obter()
        {
            return controle.Obter("Cliente");
        }
    }
}
