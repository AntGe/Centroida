using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_3_ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            string number = Console.ReadLine();
            char[] numberChar = number.ToCharArray();
            double sum = 0;
            foreach (char digit in numberChar)
            {
                sum += char.GetNumericValue(digit);
            }
            Console.WriteLine(sum);
        }
    }
}
