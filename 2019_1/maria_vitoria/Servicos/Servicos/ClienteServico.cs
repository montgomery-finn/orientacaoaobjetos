using Modelo.TiposCadastro;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Servico.Servicos
{
    public class ClienteServico
    {
        private Controle<Cliente> controle;

        public ClienteServico()
        {
            controle = new Controle<Cliente>();
        }

        public void Salvar(Cliente cliente)
        {
            controle.Salvar(cliente);
        }

        public void Editar(Cliente cliente)
        {
            controle.Editar(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            controle.Excluir(cliente);
        }

        public List<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado, string tabela)
        {
            return controle.Buscar(predicado, tabela);
        }

        public List<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return controle.Buscar(predicado);
        }

        public List<Cliente> Obter()
        {
            return controle.Obter();
        }
    }
}
