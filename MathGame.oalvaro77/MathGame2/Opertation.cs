
using System.Diagnostics;


namespace MathGame2
{
    internal class Operation
    {
        Stopwatch stopwatch = new Stopwatch();
        public void Addition(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;
            int level = Helpers.LevelOption();
            string dLevel = Helpers.PrintLevel(level);
            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                int num1 = Helpers.DificultLevel(level);
                int num2 = Helpers.DificultLevel(level);
                Console.WriteLine($"{num1} + {num2}");
                string result = Console.ReadLine();
                result = Helpers.ValidateNums(result);
                int correctResult = num1 + num2;
                if (Int32.Parse(result) == correctResult)
                {
                    Console.WriteLine("Correct result!");
                    score++;
                    Console.WriteLine($"+{score} pts");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect result.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine("Game Over. Total Score: " + $"{score} pts");
                    Console.WriteLine($"You take {stopwatch.Elapsed.Seconds} seconds to answer");
                }
            }

            Helpers.GetHistory(score, Models.GameType.Addition, stopwatch.Elapsed.Seconds, dLevel);
        }

        public void Subtraction(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;
            int level = Helpers.LevelOption();
            string dLevel = Helpers.PrintLevel(level);
            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                int num1 = Helpers.DificultLevel(level);
                int num2 = Helpers.DificultLevel(level);
                Console.WriteLine($"{num1} - {num2}");
                string result = Console.ReadLine();
                result = Helpers.ValidateNums(result);
                int correctResult = num1 - num2;
                if (Int32.Parse(result) == correctResult)
                {
                    Console.WriteLine("Correct result!");
                    score++;
                    Console.WriteLine($"+{score} pts");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect result.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {   
                    stopwatch.Stop();
                    Console.WriteLine("Game Over. Total Score: " + $"{score} pts");
                    Console.WriteLine($"You take {stopwatch.Elapsed.Seconds} seconds to answer");
                }
            }
            Helpers.GetHistory(score, Models.GameType.Subtraction, stopwatch.Elapsed.Seconds, dLevel);
        }

        public void Multiplication(string message)
        {
            
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;
            int level = Helpers.LevelOption();
            string dLevel = Helpers.PrintLevel(level);
            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                
                int num1 = Helpers.DificultLevel(level);
                int num2 = Helpers.DificultLevel(level);
                Console.WriteLine($"{num1} x {num2}");
                
                
                string result = Console.ReadLine();
                result = Helpers.ValidateNums(result);
               
                int correctResult = num1 * num2;
                if (Int32.Parse(result) == correctResult)
                {
                    Console.WriteLine("Correct result!");
                    score++;
                    
                    Console.WriteLine($"+{score} pts");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect result.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine("Game Over. Total Score: " + $"{score} pts");
                    Console.WriteLine($"You take {stopwatch.Elapsed.Seconds} seconds to answer");
                }
            }
            Helpers.GetHistory(score, Models.GameType.Multiplication, stopwatch.Elapsed.Seconds, dLevel);
        }

        public void Division(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;
            int level = Helpers.LevelOption();
            string dLevel = Helpers.PrintLevel(level);
            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {

                var divisionNumbers = IntNumDiv(level);
                int num1 = divisionNumbers[0];
                int num2 = divisionNumbers[1];
                Console.WriteLine($"{num1} / {num2}");
                string result = Console.ReadLine();
                result = Helpers.ValidateNums(result);
                int correctResult = num1 / num2;
                if (Int32.Parse(result) == correctResult)
                {
                    Console.WriteLine("Correct result!");
                    score++;
                    Console.WriteLine($"+{score} pts");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect result.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine("Game Over. Total Score: " + $"{score} pts");
                    Console.WriteLine($"You take {stopwatch.Elapsed.Seconds} seconds to answer");

                }
            }

            Helpers.GetHistory(score, Models.GameType.Division, stopwatch.Elapsed.Seconds, dLevel);
        }

        public int[] IntNumDiv(int level)
        {
            int[] divNum = new int[2];
            
            int num1 = Helpers.DificultLevel(level);
            int num2 = Helpers.DificultLevel(level);
            while (num1 % num2 != 0)
            {
                 num1 = Helpers.DificultLevel(level);
                 num2 = Helpers.DificultLevel(level);
            }
            divNum[0] = num1;
            divNum[1] = num2;

            return divNum;
        }
    }
}
