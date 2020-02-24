using Microsoft.EntityFrameworkCore;

namespace EfCoreBitflagBug
{
    public class LeadsDbContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=leads.db");
    }
}