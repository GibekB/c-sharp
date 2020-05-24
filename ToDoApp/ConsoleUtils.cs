using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ToDoApp
{
    public class ConsoleUtils
    {
        public string GetUserOption()
        {
            PrintMenu();
            var result = Console.ReadLine();

            do
            {

                if (int.TryParse(result, out int number))
                {
                    if (number > 6)
                    {

                    }
                    return result;
                }
                else
                {
                    Console.WriteLine("Please pick a valid number.");
                }
            } while (true);
        }
        public void PrintMenu()
        {
            Console.WriteLine("1 - Create a new item. 2 - Delete an item. 3 - Mark an item as done. 4 - List all items. 5 - List done items. 6 - List pending items. 7 - Exit app ");
            Console.WriteLine("Enter the option number");
        }
        public ToDoItem NewItem()
        {

            Console.WriteLine("Enter a description.");
            string desc = Console.ReadLine();

            return new ToDoItem(desc);
        }
        public int GetId()
        {
            Console.WriteLine("Please enter a ID");
            string id = Console.ReadLine();
            Int32.TryParse(id, out int iditem);
            return iditem;
        }
        public List<ToDoItem> PrintItem(List<ToDoItem> Print)
        {
            foreach (var item in Print)
            {
                Console.WriteLine($"{item.Id}-{item.Description}-{item.Pending} ");

            }
            return Print;
        }
        public void ExitApp()
        {
            Console.WriteLine("Thank you and come again.");
        }
        
    }
}
