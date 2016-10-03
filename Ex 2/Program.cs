using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired width :");
            int width = int.Parse(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(inputNumber.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
