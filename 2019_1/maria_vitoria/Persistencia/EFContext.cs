using Microsoft.EntityFrameworkCore;
using Modelo.TiposCadastro;
using Modelo.TiposServicos;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<MedicoVeterinario> MedicosVeterinarios { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<AgendaConsultas> AgendasConsulta { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<ContaCliente> ContasClientes { get; set; }
        public DbSet<Caixa> Caixa { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OO_EFCore1;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Receita>().HasOne(e => e.Animal).WithMany(x => x.Receita).Metadata.DeleteBehavior = DeleteBehavior.Restrict;
        //    modelBuilder.Entity<Receita>().HasOne(e => e.MedicoVeterinario).WithMany(x => x.Receitas).Metadata.DeleteBehavior = DeleteBehavior.Restrict;
        //}
    }
}
