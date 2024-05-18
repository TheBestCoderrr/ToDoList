using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListProject
{
    public class TaskConteinerData
    {
        public string Name { get; set; }
        public List<TaskData> tasks = new List<TaskData>();
        
    }
}
