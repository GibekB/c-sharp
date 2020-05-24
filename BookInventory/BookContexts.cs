using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace BookInventory
{
    class BookContexts : DbContext
    {
        public DbSet<Book> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "BookInventory.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
