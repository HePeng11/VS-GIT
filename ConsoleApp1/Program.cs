using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1.5));
                return 42;
            });

            var g = Task.Run(() =>
            {

            });
            




            t.Wait();
            Console.WriteLine("Task t Status: {0}, Result: {1}", t.Status, t.Result);
            Console.ReadKey();
        }
    }
}
