using System.Collections.Generic;

namespace Assignment2.Data
{
    public class TodoListService
    {
        //Instantiates a new items list
        private List<TodoItem> _items = new List<TodoItem>();

        //Returns items
        public List<TodoItem> GetItems()
        {
            return _items;
        }

        public void AddItem(string name)
        {
            _items.Add(new TodoItem { Name = name });
        }

        public void DeleteItem(TodoItem item)
        {
            _items.Remove(item);
        }
    }
    //Constructor
    public class TodoItem
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}