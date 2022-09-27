using System;
using System.Threading;
using System.Threading.Tasks;

namespace NewTims
{
    class MainThreadProgram
    {
        static void Threads(string[] args)
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
        }
    }
}