using Microsoft.EntityFrameworkCore;

namespace ChapterFirst
{
    class ContextApp : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Сompanies { get; set; }

        public ContextApp()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database = TestDb;Trusted_Connection = true");
        }
    }
}
