using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MvcApplication1.Models
{

    public class TodoItemContext : DbContext
    {
        public TodoItemContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
    }
}