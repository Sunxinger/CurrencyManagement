using System.Collections.Generic;
using System.Data.Entity;

namespace CurrencyManagement.Models
{
    public class CurrencyDbContext : DbContext
    {
        public CurrencyDbContext() : base("name=CurrencyDBConnectionString")
        {
        }

        public DbSet<Currency> Currencies { get; set; }
    }
}
