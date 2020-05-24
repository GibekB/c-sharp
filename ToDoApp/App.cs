using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
   public class App
    {
        ConsoleUtils consoleUtils;
        ItemRepository itemRepository;
      public App()
        {
            consoleUtils = new ConsoleUtils();
            itemRepository = new ItemRepository();
        }
        public void Start()
        {
            bool isRunning = true;
            while (isRunning)
            {
                var response = consoleUtils.GetUserOption();
                switch (response)
                {
                    case "1":
                        var item = consoleUtils.NewItem();
                        itemRepository.AddItem(item);
                        break;
                    case "2":
                        var DelItem = consoleUtils.GetId();
                        itemRepository.RemoveItem(DelItem);
                        break;
                    case "3":
                        var MarkItem = consoleUtils.GetId();
                        itemRepository.MarkItem(MarkItem);
                        break;
                    case "4":
                        var PrintAll = itemRepository.GetAllItem();
                        consoleUtils.PrintItem(PrintAll);
                        break;
                    case "5":
                        var PrintDone = itemRepository.DoneItem();
                        consoleUtils.PrintItem(PrintDone);
                        break;
                    case "6":
                        var PrintPending = itemRepository.PendingItem();
                        consoleUtils.PrintItem(PrintPending);
                        break;
                    case "7":
                        consoleUtils.ExitApp();
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
