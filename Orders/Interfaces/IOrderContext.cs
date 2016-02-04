using System.Data.Entity;
using Orders.Models;

namespace Orders.Interfaces
{
    public interface IOrderContext
    {
        DbSet<ECert> Certs { get; set; }
        DbSet<EClient> Clients { get; set; }
        DbSet<ECons> Conses { get; set; }
        DbSet<EConsType> ConsTypes { get; set; }
        DbSet<Error> Errors { get; set; }
        DbSet<ESourceType> SourceTypes { get; set; }
        DbSet<EWork> Works { get; set; }
        DbSet<EWorkType> WorkTypes { get; set; }

        void Save();
    }
}