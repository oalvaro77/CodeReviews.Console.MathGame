
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
