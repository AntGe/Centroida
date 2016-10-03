using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. Go to the editor
//Test Data
//Enter a number: 6 
//Enter the desired width: 6 
//Expected Output :

//666666                                                      
//66666                                                           
//6666                                                                  
//666                                                        
//66                                                                  
//6 
namespace Ex_2
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired width :");
            int width = int.Parse(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(inputNumber.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
