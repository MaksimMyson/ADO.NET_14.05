using System;
using System.Linq;
using FootballLeague.Data;
using FootballLeague.Models;

namespace FootballLeague.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballLeagueContext())
            {
                context.Database.EnsureCreated();

                if (!context.FootballTeams.Any())
                {
                    context.FootballTeams.AddRange(
                        new FootballTeam
                        {
                            TeamName = "FC Barcelona",
                            City = "Barcelona",
                            Wins = 20,
                            Losses = 5,
                            Draws = 5
                        },
                        new FootballTeam
                        {
                            TeamName = "Real Madrid",
                            City = "Madrid",
                            Wins = 22,
                            Losses = 3,
                            Draws = 5
                        }
                    );

                    context.SaveChanges();
                }

                var teams = context.FootballTeams.ToList();
                foreach (var team in teams)
                {
                    Console.WriteLine($"Team: {team.TeamName}, City: {team.City}, Wins: {team.Wins}, Losses: {team.Losses}, Draws: {team.Draws}");
                }
            }
        }
    }
}