using System.Data.Entity;
using System.Collections.Generic;

namespace Orders
{
    public class OrderContext : DbContext
    {
        public DbSet<EClient> Clients { get; set; }
        public DbSet<ECons> Conses { get; set; }
        public DbSet<EConsType> ConsTypes { get; set; }
        public DbSet<ECert> Certs { get; set; }
        public DbSet<ESourceType> SourceTypes { get; set; }
        public DbSet<EWork> Works { get; set; }
        public DbSet<EWorkType> WorkTypes { get; set; }
        public DbSet<Error> Errors { get; set; }                
    }    
}
