using System;

namespace cohort_1_2020
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Hello();
			Addition();
			CatDog();
			OddEvents();
			Inches();
			Echo();
			KillGrams();
			Date();
			Age();
			Guess();
			Console.ReadLine();
		}
		static void Hello() 
		{
			Console.WriteLine("State your name stranger, Please");
			string name;
			name = Console.ReadLine();
			Console.WriteLine("Bye " + name);
		} //Prints out a greeting and ask the user their name. Then responds with a "Bye Bob!" (replacing Bob with the name entered)

		static void Addition()
		{
			Console.WriteLine("Why don't ya pick 2 Numbers Please");
			int Num1;
			int Num2;
			Num1 = Convert.ToInt32(Console.ReadLine());
			Num2 = Convert.ToInt32(Console.ReadLine());
			int total = Num1 + Num2;
			Console.WriteLine($" Heres your results bud: { Num1 + Num2 }", (Num1 + Num2));
		}//A method that ask the user for 2 numbers and prints out their sum
		static void CatDog()
		{
			Console.WriteLine("Do ya like Cats or Dogs");
			string input;
			string Dogs = "Dogs";
			string Cats = "Cats";
			input = Console.ReadLine();
			if (Dogs == input) 
			{
				Console.WriteLine("bark");
			}
			else if (Cats == input)
			{
				Console.WriteLine("Meow");
			}
			else
			{
				Console.WriteLine("That ain't the question boy");
			}
		}// A method that ask the user if they prefer cats or dogs, and either "Barks" or "Meows" back depending on what they entered.
		static void OddEvents()
		{
			Console.WriteLine("Pick a number");
			int number;
			number = Convert.ToInt32(Console.ReadLine());
			int math;
			math = number % 2;
			if (math == 0)
			{
				Console.WriteLine("That is an even number boy");
			}
			else
			{
				Console.WriteLine("That is an odd number my friend");
			}
		}// A method that asks the user for a number, and prints out if it is odd or even
		static void Inches()
		{
			Console.WriteLine("Whats your hight in feet");
			int Number = Convert.ToInt32(Console.ReadLine());
			int math = Number * 12;
			Console.WriteLine("Your hight in inches would be " + math);
		}// A method that ask the user for a height in feet and returns the height converted to inches
		static void Echo()
		{
			Console.WriteLine("Say a word to hear an echo partner");
			string word = Console.ReadLine();
			Console.WriteLine(word.ToUpper());
			Console.WriteLine(word.ToLower());
			Console.WriteLine(word.ToLower());

		}// A method that ask the user for a word then prints it 3 times, first in all caps, then 2 more time in all lower case
		static void KillGrams()
		{
			Console.WriteLine("How much do you weigh in pounds parter?");
			int number = Convert.ToInt32(Console.ReadLine());
			double math = number * .454;
			Console.WriteLine("Your weight in grams is " + math);
		}// A method that ask the user for a weight in pounds, then converts it to killograms
		static void Date()
		{
			Console.WriteLine(DateTime.Now);
		}//A method that prints out the current date
		static void Age()
		{
			Console.WriteLine("What year were you born partner?");
			int birthyear;
			var today = DateTime.Now;
			birthyear = int.Parse(Console.ReadLine());
			var Age = today.Year-birthyear;
			Console.WriteLine("Your age is " + Age);
		}//A method that asks the user their birth year, and print out their age
		static void Guess()
		{
			Console.WriteLine("Guess a word partner");
			string input;
			string csharp = "csharp";
			input = Console.ReadLine();
			if (csharp == input) 
			{
				Console.WriteLine("CORRECT!!");
			}
			else
			{
				Console.WriteLine("WRONG!!");
			}
			

		}// A method that ask the user to guess a word, and print out 'CORRECT!!' if the word is "chsarp", otherwise prints out 'WRONG!!'

	}
}