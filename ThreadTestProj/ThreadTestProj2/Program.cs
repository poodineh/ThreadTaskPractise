using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTestProj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main threadId: " + Thread.CurrentThread.ManagedThreadId);

            Task task = Task.Run(() => Add(2,6));
            Task<int> task2 = new Task<int>(()=>Add(2,6));
            task2.Start();
            Console.WriteLine("Task in Main method.");
            Console.WriteLine("Task2 : ");
            Console.WriteLine(task2.Result);
            Console.ReadKey();
        }

        private static int Add(int n1, int n2)
        {
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                x++;
                Thread.Sleep(100);
                Console.WriteLine(x + " -> Add threadId: " + Thread.CurrentThread.ManagedThreadId);
            }
            return n1 + n2;
        }
    }
}
