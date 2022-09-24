using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class BancoDeDados: DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: "Server=127.0.0.1;Port=5432;User Id=admin;Password=admin;Database=postgres;");
        }
            
    }
}
