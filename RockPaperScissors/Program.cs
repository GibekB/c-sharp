using System;

namespace RockPaperSiccors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("Do you choose rock,paper or scissors");
                string userChoice = Console.ReadLine();

                Random r = new Random();
                int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie ");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose,paper beat rock");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose,scissors beat paper ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose,rock beats scissors");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win,rock beats scissors");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win,paper beats rock");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win,scissors beat paper");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }

                Console.WriteLine("New game? y/n");
                ConsoleKeyInfo cki = Console.ReadKey();
                keepPlaying = cki.KeyChar == 'y';
                Console.Clear();
            }
        }
    }
}
