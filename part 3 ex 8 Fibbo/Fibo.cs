using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to create a function to display the n number fibonacci sequence. Go to the editor
//Test Data : 
//Input number of Fibonacci Series : 5 
//Expected Output : 
//The Fibonacci series of 5 numbers is : 
//0 1 1 2 3
namespace part_3_ex_8_Fibbo
{
    class Fibo
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
