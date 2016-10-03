using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to print numbers from n to 1 using recursion. Go to the editor
//Test Data :
//How many numbers to print : 10 
//Expected Output : 
//10 9 8 7 6 5 4 3 2 1
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
