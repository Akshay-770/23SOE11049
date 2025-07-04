using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("inter a");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter b");
            int b=Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            // string interploation
            Console.WriteLine($"sum is {a} + {b} "+sum);
            Console.ReadLine();
        }
    }
}
