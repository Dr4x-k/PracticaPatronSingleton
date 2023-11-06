using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSingleton
{
    public class Task
    {
        public int taskId {  get; set; }
        public string taskName { get; set; }

        public string taskDescription { get; set; }

        public string taskStatus { get; set; }

        public string taskPriority { get; set; }

        public Task(int id, string name, string description, string status, string priority) {
            taskId = id;
            taskName = name;
            taskDescription = description;
            taskStatus = status;
            taskPriority = priority;
        }
    }
}
