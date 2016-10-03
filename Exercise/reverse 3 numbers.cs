using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# Sharp program that takes three letters as input and display them in reverse order. Go to the editor
//Test Data
//Enter letter: b
//Enter letter: a
//Enter letter: t
//Expected Output :
//t a b
namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr  = new string[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number :");
                arr[i] = (Console.ReadLine().ToString());
            }
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
