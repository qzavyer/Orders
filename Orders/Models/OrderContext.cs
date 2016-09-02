using System.Data.Entity;
using Orders.Interfaces;

namespace Orders.Models
{
    public class OrderContext : DbContext, IOrderContext
    {
        /*public DbSet<BackupLog> BackupLogs { get; set; }
        public DbSet<EClient> Clients { get; set; }
        public DbSet<ECons> Conses { get; set; }
        public DbSet<EConsType> ConsTypes { get; set; }
        public DbSet<ECert> Certs { get; set; }
        public DbSet<ESourceType> SourceTypes { get; set; }
        public DbSet<EWork> Works { get; set; }
        public DbSet<EWorkType> WorkTypes { get; set; }
        public DbSet<Error> Errors { get; set; }*/

        public string ConnectionString => Database.Connection.ConnectionString;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BackupLog>().ToTable("tBackupLog");
            modelBuilder.Entity<EClient>().ToTable("tClient");
            modelBuilder.Entity<ECons>().ToTable("tCons");
            modelBuilder.Entity<EConsType>().ToTable("tConsType");
            modelBuilder.Entity<ECert>().ToTable("tSert");
            modelBuilder.Entity<ESourceType>().ToTable("tSource");
            modelBuilder.Entity<EWork>().ToTable("tWork");
            modelBuilder.Entity<EWorkType>().ToTable("tWorkType");
            modelBuilder.Entity<Error>().ToTable("tError");
        }

        public void Save()
        {
            SaveChanges();
        }
    }
}

