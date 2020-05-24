using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Pending { get; set; }

        public ToDoItem(string description)
        {
            Description = description;
            Pending = true;
        }
    }
}
