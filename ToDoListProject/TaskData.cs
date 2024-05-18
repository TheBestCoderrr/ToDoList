using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListProject
{
    public class TaskData
    {
        public string Name { get; set; }
        public string MultiText { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; } 
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
        public TaskData()
        {
            Priority = 0;
            Date =  new DateTime();
        }
    }
}
