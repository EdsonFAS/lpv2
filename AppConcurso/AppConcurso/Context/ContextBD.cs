using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Context
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) { 
        }

        public DbSet<AppConcurso.Models.Candidato> Candidatos { get; set; }
        public DbSet<AppConcurso.Models.Cargo> Cargos { get; set; }
        public DbSet<AppConcurso.Models.Inscricao> Inscricoes { get; set; }
    }
}
