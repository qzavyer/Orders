using System.Data.Entity;
using Orders.Interfaces;

namespace Orders.Models
{
    public class OrderContext : DbContext, IOrderContext
    {
        public DbSet<EClient> Clients { get; set; }
        public DbSet<ECons> Conses { get; set; }
        public DbSet<EConsType> ConsTypes { get; set; }
        public DbSet<ECert> Certs { get; set; }
        public DbSet<ESourceType> SourceTypes { get; set; }
        public DbSet<EWork> Works { get; set; }
        public DbSet<EWorkType> WorkTypes { get; set; }
        public DbSet<Error> Errors { get; set; }

        public string ConnectionString => Database.Connection.ConnectionString;

        public void Save()
        {
            SaveChanges();
        }

        
    }
}

