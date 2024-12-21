using MathGame2.Models;


namespace MathGame2
{
    internal static class Helpers
    {
        static List<Game> game = new List<Game>();
        
        internal static void GetName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            name = ValidateName(name);
            Console.WriteLine($"Welcome {name} {DateTime.Now}");
        }

        internal static string ValidateName(string name)
        {
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name is invalid");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static string ValidateOption(string option)
        {
            while (string.IsNullOrEmpty(option) || !Int32.TryParse(option, out _))
            {
                Console.WriteLine("The option is invalid");
                option = Console.ReadLine();
            }
            return option;
        }

        internal static string ValidateNums(string num)
        {
            while (string.IsNullOrEmpty(num) || !Int32.TryParse(num, out _))
            {
                Console.WriteLine("The value is invalid");
                num = Console.ReadLine();
            }

            return num;
        }

        internal static void GetHistory(int score, GameType type, int time, string level)
        {
            game.Add(new Game { Date = DateTime.Now, Score = score, Type = type, Time = time, Level = level});
        }

        internal static void PrintHistory()
        {
            Console.Clear();
            
            
            foreach (Game games in game)
            {
                Console.WriteLine($"{games.Date} {games.Score} pts {games.Type}, take {games.Time} seconds, level {games.Level}");
            }
            game = OrderBy();
            Console.Clear();
        }

        internal static List<Game> OrderBy()
        {
            string input;
            do
            {
                Console.WriteLine("1. Order by score \t 2. Order by date \t 3. Go to back to main menu");
                input = Console.ReadLine();
                input = Helpers.ValidateOption(input);
                Int32.TryParse(input, out int val);
                switch (val)
                {
                    case 1:
                        Console.Clear();
                        game = game.OrderByDescending((x) => x.Score).ToList();
                        foreach (Game games in game)
                        {
                            Console.WriteLine($"{games.Date} {games.Score} pts {games.Type}");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        game = game.OrderByDescending(x => x.Date).ToList();
                        foreach (Game games in game)
                        {
                            Console.WriteLine($"{games.Date} {games.Score} pts {games.Type}");
                        }
                        break;
                    case 3:

                        break;
                }

            } while (input != "3");
           
            return game;
        }

        internal static int DificultLevel(int level)
        {
            int num1 = 0;
            Random random = new Random();
            if (level == 0) { num1 = random.Next(1, 9); }
            else if (level == 1) {  num1 = random.Next(1, 99); }
            else if (level == 2) {  num1 = random.Next(-99, 99); }
            return num1;
        }

        internal static int LevelOption()
        {
            
            Console.WriteLine("Select level option");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("?:");
            string input = Console.ReadLine();
            ValidateOption(input);
            Int32.TryParse(input, out int level);
            
            Console.Clear();
            if (level == 1 ) { Console.WriteLine("You select easy");  return 0; }
            else if (level == 2 ) { Console.WriteLine("You select medium"); return 1; }
            else if (level == 3 ) { Console.WriteLine("You select hard"); return 2; }

            return 0;

        }

        internal static string PrintLevel(int level)
        {
            string dLevel = null;
            if (level == 0) { dLevel = "Easy"; }
            else if (level == 1) { dLevel = "Medium"; }
            else if (level == 2) { dLevel = "Hard"; }

            return dLevel;
        }
            
        
    }
}
