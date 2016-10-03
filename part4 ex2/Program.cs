using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part4_ex2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter start number : ");
            int startNumber = int.Parse(Console.ReadLine());
            RecursionNumbers(startNumber);
        }
        public static void RecursionNumbers(int number)
        {
            if (number > 0)
            {
                Console.WriteLine(number);
                RecursionNumbers(number - 1);
            }
        }
    }
}
