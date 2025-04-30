using appMulta.Model;
using Microsoft.EntityFrameworkCore;

namespace appMulta.Context
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options): base (options)
        {

        }

        public DbSet<Veiculo> Veiculo { get; set; } 
        public DbSet<Multa> Multas { get; set; }
    }
}
