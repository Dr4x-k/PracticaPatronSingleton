using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSingleton
{
    public sealed class TaskManager
    {
        private static TaskManager instance = null;
        private static readonly object padlock = new object();

        private List<Task> tasks = new List<Task>();

        private TaskManager() { }

        public static TaskManager Instance 
        {
            get 
            {
                lock (padlock) 
                {
                    if (instance == null)
                    {
                        instance = new TaskManager();
                    }
                    return instance;
                }
            }
        }


        //Aquí vendría todos los métodos del task manager, agregar nueva tarea, listar tareas, cambiar estatus, etc

    }
}
