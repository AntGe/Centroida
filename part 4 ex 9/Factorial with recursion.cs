using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_4_ex_9
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter start number : ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursionNumbers(startNumber));
        }
        public static int RecursionNumbers(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * RecursionNumbers(number - 1);
        }
    }
}
