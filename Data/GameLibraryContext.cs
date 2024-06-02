using Microsoft.EntityFrameworkCore;
using GameLibrary.Models;
using System.Collections.Generic;

namespace GameLibrary.Data
{
    public class GameLibraryContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string_here");
        }
    }
}