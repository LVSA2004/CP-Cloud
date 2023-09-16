using CP_Cloud.Models;
using Microsoft.EntityFrameworkCore;

namespace CP_Cloud.Persistence
{
    public class OracleDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options)
        {

        }
    }
}
