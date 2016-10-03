using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Go to the editor
//Test Data : 
//Enter a number: 1234 
//Expected Output : 
//The sum of the digits of the number 1234 is : 10
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
