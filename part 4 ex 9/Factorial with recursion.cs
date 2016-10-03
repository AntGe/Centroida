using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to find the factorial of a given number using recursion. Go to the editor
//Test Data :
//Input any positive number : 5 
//Expected Output : 
//The factorial of 5 is : 120 
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
