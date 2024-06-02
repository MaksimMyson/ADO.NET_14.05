using Microsoft.EntityFrameworkCore;
using FootballLeague.Models;
using System.Collections.Generic;

namespace FootballLeague.Data
{
    public class FootballLeagueContext : DbContext
    {
        public DbSet<FootballTeam> FootballTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FootballLeague;Trusted_Connection=True;");
        }
    }
}