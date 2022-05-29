using System;
using System.Threading;

namespace Philosophers
{
    class Program
    {
        static void Main(string[] args)
        {
            Fork fork = new Fork();
            new Philosopher(0, 500, 500, fork);
            new Philosopher(1, 500, 500, fork);
            new Philosopher(2, 500, 500, fork);
            new Philosopher(3, 500, 500, fork);
            new Philosopher(4, 500, 500, fork);
        }
    }
}
