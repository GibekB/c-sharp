using System;
using System.Collections.Generic;
using System.Text;

namespace BookInventory
{
   public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}
