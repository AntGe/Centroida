using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).
namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  x = y * y + 2y + 1 ");
            for (int i = -5; i <= 5; i++)
            {
                int y = i;
                Console.WriteLine(i);
                Console.WriteLine("  x = {0}", Math.Pow(y, 2) + 2 * y + 1);
                Console.WriteLine("  y = {0}",y);
                Console.WriteLine();


            }
        }
    }
}
