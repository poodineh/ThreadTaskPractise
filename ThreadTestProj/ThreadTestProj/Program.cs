using System;
using System.Threading;

namespace ThreadTestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(Thread1Job);
            var thread2 = new Thread(Thread2Job);
            var thread3 = new Thread(Thread3Job);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private static void Thread3Job()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " from thread3:" + i);
            }
        }

        private static void Thread2Job()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " from thread2:" + i);
            }
        }

        private static void Thread1Job()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " from thread1:" + i);
            }
        }
    }
}
