using System;
using System.Linq;
using GameLibrary.Data;
using GameLibrary.Models;

namespace GameLibrary.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GameLibraryContext())
            {
                context.Database.EnsureCreated();

                if (!context.Games.Any())
                {
                    context.Games.AddRange(
                        new Game
                        {
                            Name = "The Witcher 3: Wild Hunt",
                            Studio = "CD Projekt Red",
                            Genre = "RPG",
                            ReleaseDate = new DateTime(2015, 5, 19)
                        },
                        new Game
                        {
                            Name = "Cyberpunk 2077",
                            Studio = "CD Projekt Red",
                            Genre = "RPG",
                            ReleaseDate = new DateTime(2020, 12, 10)
                        }
                    );

                    context.SaveChanges();
                }

                var games = context.Games.ToList();
                foreach (var game in games)
                {
                    Console.WriteLine($"Name: {game.Name}, Studio: {game.Studio}, Genre: {game.Genre}, Release Date: {game.ReleaseDate.ToShortDateString()}");
                }
            }
        }
    }
}