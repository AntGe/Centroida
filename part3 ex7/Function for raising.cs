using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. Go to the editor
//Test Data : 
//Input Base number: 3 
//Input the Exponent : 2 
//Expected Output : 
//So, the number 3 ^ (to the power) 2 = 9
namespace part3_ex7
{
    class Program
    {
        static double Raise(double numer, double raise)
        {
            return Math.Pow(numer, raise);
            
        }
        static void Main()
        {
            Console.WriteLine("Enter number :");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter power :");
            double power = double.Parse(Console.ReadLine());
            double raised = Raise(number, power);
            Console.WriteLine("Raised :" + raised);
            
            
        }
    }
}
