namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList list1 = new ToDoList();
            Task task1 = new Task("Go to school");
            Task task2 = new Task("Sleep");
            Task task3 = new Task();

            list1.InsertTask(task1);
            list1.InsertTask(task2);
            list1.InsertTask(task3);
            list1.DisplayTasks();
            Console.WriteLine("---------");
            list1.UpdateTask(0, "wake Up");
            list1.DisplayTasks();
            Console.WriteLine("---------");
            list1.RemoveTasks(1);
            list1.DisplayTasks();
            Console.WriteLine("---------");
        }
    }
}
