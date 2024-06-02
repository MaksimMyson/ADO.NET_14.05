using System;

namespace GameLibrary.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string GameMode { get; set; } // Нове поле
        public int CopiesSold { get; set; } // Нове поле
    }
}