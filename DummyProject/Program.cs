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
            // test code
            Console.WriteLine($"Enter numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = sumNo(num1, num2);
            Console.WriteLine($"Sum of Numbers {sum}");
            Console.ReadLine();

        }
        public static int sumNo(int num1,int num2)
        {
            
            return num1 + num2;
        }
    }
}
