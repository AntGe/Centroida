using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
