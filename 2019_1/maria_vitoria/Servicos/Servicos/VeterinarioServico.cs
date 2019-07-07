using Modelo.TiposCadastro;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Servico.Servicos
{
    public class VeterinarioServico
    {
        private Controle<MedicoVeterinario> controle;

        public VeterinarioServico()
        {
            controle = new Controle<MedicoVeterinario>();
        }

        public void Salvar(MedicoVeterinario veterinario)
        {
            controle.Salvar(veterinario);
        }

        public void Editar(MedicoVeterinario veterinario)
        {
            controle.Editar(veterinario);
        }

        public void Excluir(MedicoVeterinario veterinario)
        {
            controle.Excluir(veterinario);
        }

        public List<MedicoVeterinario> Buscar(Expression<Func<MedicoVeterinario, bool>> predicado, string tabela)
        {
            return controle.Buscar(predicado, tabela);
        }

        public List<MedicoVeterinario> Buscar(Expression<Func<MedicoVeterinario, bool>> predicado)
        {
            return controle.Buscar(predicado);
        }

        public List<MedicoVeterinario> Obter()
        {
            return controle.Obter();
        }
    }
}
