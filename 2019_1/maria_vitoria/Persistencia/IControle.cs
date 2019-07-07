using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Persistencia
{
    public interface IControle<M> where M : class
    {
        void Gravar(M entidade);

        List<M> ObterTodos(string tabela);

        M Ultimo();

        void Excluir(M entidade);

        List<M> Buscar(Expression<Func<M, bool>> predicado);

        List<M> Buscar(Expression<Func<M, bool>> predicado, string tabela);

        List<M> Buscar(Expression<Func<M, bool>> predicado, string tabela, string tabela2);
    }
}
