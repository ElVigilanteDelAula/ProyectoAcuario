using Microsoft.EntityFrameworkCore;
using acuario.Entidades;
namespace acuario
{
    public class ApplicationDb: DbContext 
    {
        public ApplicationDb(DbContextOptions options) : base(options) 
        { 
        
        }

        public DbSet<Acuario> Acuario { get; set; } 
    }
}

