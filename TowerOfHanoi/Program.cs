using System;
using System.Collections.Generic;

namespace TowersOfhanoi 
{
    // TowersOfHanoi 
    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        // The dictionary is the board that holds up and organizes my string and stacks(poles)
        static void Main(string[] args) 
        {
            Stack<int> stack = new Stack<int>();
            // this is making a stack
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            // Adding numbers to the stack for my four disks
            board.Add("A", stack);
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());
            // This names my dictionary keys A, B, and C and give it a value of a stack

            do
            {
                Console.Clear();
                PrintBoard();
                // prints my playing board
                Console.WriteLine("Choose a tower (A, B, C,) to move from.");
                string from = Console.ReadLine().ToUpper();
                // this string records the data of where the player wants to move the disk from
                Console.WriteLine("Choose to move to tower (A, B, C,).");
                string to = Console.ReadLine().ToUpper();
                // this string prints the data of where the player want to move the disk to

                if (IsMoveValid(from, to))
                {
                    board[to].Push(board[from].Pop());
                }
                 // moving disks(stacks) from pole to pole(boards) if the move is valid
                else
                {
                    Console.WriteLine("Wrong move buster.");
                    Console.WriteLine("Press (SPACE) for a second chance.");
                    Console.ReadKey();
                } // this alerts the player of a wrong move

            } while (!CheckWin());
             // this is connected to do repeating the code if checkwin is not true
            Console.Clear();
            PrintBoard();
            Console.WriteLine("Well i'll be darned you're as smart as a monkey");
            Console.ReadKey();
        } // tells the player they won the game

        private static bool IsMoveValid(string from, string to) // checks if a move is valid
        {
            if (board[from].Count == 0)
            {
                // no disks(stacks) present
                return false;
            }
            else if (to == from)
            {
                // can't move a peg from and to the same pole(board)
                return false;
            }
            // check that the destination pole(board) is not empty before using Peek, otherwise it will throw an error
            else if (board[to].Count != 0)
            {
                // A bigger disk (stack) cant be on top of a smaller one (presented by numbers) 
                if (board[to].Peek() > board[from].Peek())
                {
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            } // this checks out valid
        }
        private static bool CheckWin() // checks if the player wins
        {
            // You need to move all the disks(stacks 1,2,3,4) from pole A (baord A) to pole C (board C) from greates (4) to smallest (1)
            if (board["C"].Count == 4)
            {
                return true;
            }
            return false;
        } 
        private static void PrintBoard() // prints the starting and up
        {
            foreach (var item in board)
                // the fareach goes trough the dictionary item by item 
            {
                Console.Write($"\n{item.Key}: ");
                // this prints out the three keys A, B, and C onto the board
                var numbers = item.Value.ToArray();
                // This saves my value 1, 2, 3, and 4 to an array
                for (int i = numbers.Length; i > 0; i--)
                    // goes through the stack/array(disk) backwards
                {
                    Console.Write(numbers[i - 1] + " ");
                } // this prints the numbers 1, 2, 3, and 4 onto the keys
                Console.WriteLine();
            }
        }
    }
}
