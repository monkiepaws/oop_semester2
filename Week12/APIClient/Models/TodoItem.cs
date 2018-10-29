using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Models
{
    public class TodoItem
    {
        public string task { get; set; }
        public Guid id { get; set; }
        public TodoItem()
        {

        }
        public TodoItem(string task)
        {
            this.task = task;
        }
        public TodoItem (string task, Guid id)
        {
            this.task = task;
            this.id = id;
        }
    }
}
