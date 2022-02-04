using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTestProj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var class1 = new class1();
            class1.RunTask();
            class1.task2.Start();
            Console.ReadKey();
        }
    }

    public class class1
    {
        Task task1 = new Task(() => {
            Console.WriteLine("task1");
            Thread.Sleep(1000);
            });

        public Task task2 = new Task(() => Console.WriteLine("task2"));
        public void RunTask()
        {
            task1.Start();
        }
    }
}
