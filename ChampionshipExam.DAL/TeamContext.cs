using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace ChampionshipExam.DAL
{
    public class TeamContext : DbContext
    {

        public TeamContext()
        { }

        public DbSet<Team>? Teams { get; set; }

        public DbSet<Matches> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}