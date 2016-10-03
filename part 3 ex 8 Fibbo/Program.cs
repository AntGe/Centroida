using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_3_ex_8_Fibbo
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int number = 0;
            int secondNum = 1;
            
            for (int i = 0; i < n; i++)
            {
                int numberTemp = number;
                number = secondNum;
                secondNum = numberTemp + secondNum;
            }
            return number;
        }

        static void Main()
        {
            Console.WriteLine("Enter how many numbers you want :");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
