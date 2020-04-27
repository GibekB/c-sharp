using System;
using System.Collections.Generic;

namespace TowersOfhanoi //totally not stolen
{
    // TowersOfHanoi 
    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            board.Add("A", stack);
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());

            do
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Choose a tower (A, B, C,) to move from.");
                string from = Console.ReadLine().ToUpper();
                Console.WriteLine("Choose to move to tower (A, B, C,).");
                string to = Console.ReadLine().ToUpper();

                if (IsMoveValid(from, to))
                {
                    board[to].Push(board[from].Pop());
                }
                 // moving disks(stacks) from pole to pole(boards)
                else
                {
                    Console.WriteLine("Wrong move buster.");
                    Console.WriteLine("Press (SPACE) for a second chance.");
                    Console.ReadKey();
                }

            } while (!CheckWin());

            Console.Clear();
            PrintBoard();
            Console.WriteLine("Well i'll be darned you're as smart as a monkey");
            Console.ReadKey();
        }

        private static bool IsMoveValid(string from, string to)
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

        private static bool CheckWin()
        {
            // You need to move all the disks(stacks 1,2,3,4) from pole A (baord A) to pole C (board C) from greates (4) to smallest (1)
            if (board["C"].Count == 4)
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard()
        {
            foreach (var item in board)
            {
                Console.Write($"\n{item.Key}: ");
                var numbers = item.Value.ToArray();
                // updates the board
                for (int i = numbers.Length; i > 0; i--)
                {
                    Console.Write(numbers[i - 1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
