using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_2_ex_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght :");
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLenght];
            for (int i = 0; i < arrLenght; i++)
            {
                Console.WriteLine("element " + i.ToString() + " :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Second smallest = " + arr[1]);
            
        }
    }
}
