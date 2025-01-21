using System.Collections.Generic;

namespace ToDo.Models
{
    public class ToDoModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public List<string> ToDoList { get; set; }

        public ToDoModel()
        {
            ToDoList = new List<string>();
        }
    }
}