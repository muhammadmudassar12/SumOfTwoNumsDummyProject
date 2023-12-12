using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine($"Enter numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine($"Sum of Numbers {sum}");
            Console.ReadLine();

        }
    }
}
