using Microsoft.EntityFrameworkCore;

namespace ProjetoCorreiosAPI.Model
{
    public class DbCorreiosContext : DbContext
    {
        public DbCorreiosContext(DbContextOptions<DbCorreiosContext> options) : base(options){ }

        public DbSet<Pacotes> Pacotes { get; set; }
    }
}
