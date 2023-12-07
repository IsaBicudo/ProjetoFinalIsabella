using Microsoft.EntityFrameworkCore;
using ProjetoFinalIsabella.Models;

namespace ProjetoFinalIsabella.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ProjetoFinalIsabella.Models.Cidade>? Cidade { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.Cliente>? Cliente { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.Colaborador>? Colaborador { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.Estado>? Estado { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.LocalRealizacao>? LocalRealizacao { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.Procedimento>? Procedimento { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.ProcedimentoRealizacao>? ProcedimentoRealizacao { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.TipoColaborador>? TipoColaborador { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.TipoProcedimento>? TipoProcedimento { get; set; }
        public DbSet<ProjetoFinalIsabella.Models.Usuario>? Usuario { get; set; }

    }
}
