using Microsoft.EntityFrameworkCore;
using DataAccess.Model;

namespace DataAccess
{
    public class ContextBD: DbContext
    {
        public DbSet<Client> CLIENT { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TH2ROKM\SQLEXPRESS;Initial catalog=DB_CLIENT; Integrated Security=true");
        }
    }
}
