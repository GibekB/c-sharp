using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease pick two colors. Red, Blue, or Yellow.");
            Console.WriteLine("Enter your guess seperated by a space.");

            string answer = Console.ReadLine().ToLower();
            string[] userColors = answer.Split(' ');

            Random random = new Random();
            int first = random.Next(1, 3);
            int second = random.Next(1, 3);

            string computerColor1 = string.Empty;
            switch (first)
            {
                case 1:
                    computerColor1 = "red";
                    break;
                default:
                    break;
            }

            bool isPlaying = false;
            do
            {



            } while (isPlaying);
        }
    }
}
