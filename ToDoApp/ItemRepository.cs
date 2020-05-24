using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoApp
{
    public class ItemRepository
    {
        ItemContext itemContext;

        public ItemRepository()
        {
            itemContext = new ItemContext();
            itemContext.Database.EnsureCreated();
        }
        public void AddItem(ToDoItem item)
        {
            itemContext.Add(item);
            itemContext.SaveChanges();
        }
        public void RemoveItem(int item)
        {
            ToDoItem remove = itemContext.ToDoItem.Where(x => x.Id == item).FirstOrDefault();
            itemContext.Remove(remove);
            itemContext.SaveChanges();
            
        }
        public List<ToDoItem> GetAllItem()
        {
            List<ToDoItem> list = new List<ToDoItem>();
            list = itemContext.ToDoItem.ToList();
            return list;
        }

        public List<ToDoItem> PendingItem()
        {
            List<ToDoItem> list = new List<ToDoItem>();
            list = itemContext.ToDoItem.Where(x => x.Pending == true).ToList();
            return list;
        }
        public List<ToDoItem> DoneItem()
        {
            List<ToDoItem> list = new List<ToDoItem>();
            list = itemContext.ToDoItem.Where(x => x.Pending == false).ToList();
            return list;
        }
        public void MarkItem(int item)
        {
            ToDoItem done = itemContext.ToDoItem.Where(x => x.Id == item).FirstOrDefault();
            if(done.Pending == true)
            {
                done.Pending = false;
            }
            else
            {
                done.Pending = true;   
            }
        }
    }
}
