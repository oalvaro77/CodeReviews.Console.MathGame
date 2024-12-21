using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame2.Models
{
    internal class Game
    {
        public DateTime Date {  get; set; }

        public int Score { get; set; }

        public GameType Type { get; set; }

        public int Time { get; set; }

        public string Level { get; set; }
    }

    public enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
        
}
