using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Persistencia
{
    public class Controle<M> : IControle<M> where M : class
    {
        public Controle()
        {
        }

        public void Salvar(M entidade)
        {
            using (var context = new EFContext())
            {
                context.Set<M>().Add(entidade);
                context.SaveChanges();
            }
        }

        public List<M> Obter()
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().ToList();
            }
        }

        public List<M> Obter(string tabela)
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().Include(tabela).ToList();
            }
        }

        public List<M> Obter(string tabela, string tabela2)
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().Include(tabela).Include(tabela2).ToList();
            }
        }
        public M Ultimo()
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().LastOrDefault();
            }
        }

        public void Excluir(M entidade)
        {
            using (var context = new EFContext())
            {
                context.Set<M>().Remove(entidade);
                context.SaveChanges();
            }
        }

        public List<M> Buscar(Expression<Func<M, bool>> predicado)
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().Where(predicado).ToList();
            }
        }

        public List<M> Buscar(Expression<Func<M, bool>> predicado, string tabela)
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().Include(tabela).Where(predicado).ToList();
            }
        }

        public List<M> Buscar(Expression<Func<M, bool>> predicado, string tabela, string tabela2)
        {
            using (var context = new EFContext())
            {
                return context.Set<M>().Include(tabela).Include(tabela2).Where(predicado).ToList();
            }
        }

        public void Editar(M entidade)
        {
            using (var context = new EFContext())
            {
                context.Entry(entidade).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Gravar(M entidade)
        {
            throw new NotImplementedException();
        }

        public List<M> ObterTodos(string tabela)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Expression<Func<M, bool>> predicado)
        {
            using (var context = new EFContext())
            {
                if ((context.Set<M>().Where(predicado).Count()) != 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
