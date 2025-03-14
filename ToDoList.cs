using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class ToDoList
    {
        List<Task> tasks = new List<Task>();
        public void InsertTask(Task task)
        {
            tasks.Add(task);
        }

        public void DisplayTasks()
        {
            int i = 1;
            foreach (var item in tasks)
            {
                Console.WriteLine("{0}: {1}",i, item.GetDescription());
                i++;
            }
        }
        public Task UpdateTask(int i, string updatedescription)
        {
            tasks[i].SetDescription(updatedescription);
            return tasks[i];
        }
        public void RemoveTasks(int i)
        { 
            tasks.RemoveAt(i);
        }
    }
}
