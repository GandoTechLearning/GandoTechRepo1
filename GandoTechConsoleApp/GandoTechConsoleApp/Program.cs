using System;
using System.Threading;

namespace GandoTechConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"GandoTech app started at {DateTime.Now.ToUniversalTime()}");
            Console.WriteLine($"=========================================================");
            var stopTime = DateTime.Now.ToUniversalTime().AddMinutes(5);
            while (DateTime.Now.ToUniversalTime() < stopTime)
            {
                Console.WriteLine($"GandoTech app is going to sleep at {DateTime.Now.ToUniversalTime()}");
                Thread.Sleep(5000);
                Console.WriteLine($"GandoTech app is running at {DateTime.Now.ToUniversalTime()}");
            }
            Console.WriteLine($"=========================================================");
            Console.WriteLine($"GandoTech app stopped at {DateTime.Now.ToUniversalTime()}");
            Console.ReadKey();
        }
    }
}
