using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork_06
{
    internal class Program
    {
        static Semaphore sem = new Semaphore(5, 5);
        static Semaphore cntThread = new Semaphore(20, 20);
        static void Main(string[] args)
        {
            //sem.WaitOne(); // 10 ==> 9 Taking the one
            //sem.Release(); //  9 ===> 10 Giving back one 
            for (int i = 0; i < 20; ++i)
            {
                cntThread.WaitOne(); // cntThread--;
                ThreadPool.QueueUserWorkItem(ThreadProc);
            }
            // Ожидание потоков.
            for (int i = 0; i < 20; ++i)
            {
                cntThread.WaitOne(); // cntThread--;
            }

            Console.WriteLine("Good bye...Main exit");
            Console.ReadLine();
        }

        static public void ThreadProc(object param)
        {
            sem.WaitOne(); // Получить 'билет' от семафора на исполнение.
            
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread {id} started");
            Random rnd = new Random(id);
            Thread.Sleep(rnd.Next(300, 1000)); // 300...1000 ms
            Console.WriteLine($"Thread {id} exit");
            
            sem.Release(); // Вернуть 'билет' в семафор.

            cntThread.Release(); // Сигнал главному потоку, что текущий поток завершил работу. --- cntThread++;
        }
    }
}
