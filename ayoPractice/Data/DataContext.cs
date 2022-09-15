using ayoPractice.Entities;
using Microsoft.EntityFrameworkCore;

namespace ayoPractice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MetricImperialUnit> MetricImperialUnits { get; set; }
    }
}
