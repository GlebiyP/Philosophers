using System;
using System.Threading;

namespace Philosophers
{
    class Philosopher
    {
        int n;
        int thinkDelay;
        int eatDelay;
        int left, right;
        Fork fork;

        public Philosopher(int n, int thinkDelay, int eatDelay, Fork fork)
        {
            this.n = n;
            this.thinkDelay = thinkDelay;
            this.eatDelay = eatDelay;
            this.fork = fork;
            left = n == 0 ? 4 : n - 1;
            right = (n + 1) % 5;
            new Thread(new ThreadStart(Run)).Start();
        }

        public void Run()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Philosopher " + n + " is thinking...");
                    Thread.Sleep(thinkDelay);
                    Console.WriteLine("Philosopher " + n + " is hungry...");
                    fork.Get(left, right);
                    Console.WriteLine("Philosopher " + n + " is eating...");
                    Thread.Sleep(eatDelay);
                    fork.Put(left, right);
                }
                catch
                {
                    return;
                }
            }
        }
    }
}