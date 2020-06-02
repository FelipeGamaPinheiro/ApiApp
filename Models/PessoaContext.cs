using Microsoft.EntityFrameworkCore;

namespace ApiApp.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
