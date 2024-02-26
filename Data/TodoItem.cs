using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class ToDoItem
    {
        //Sets ID for calling the variable
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        //Constructor
        public ToDoItem(string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }
}
