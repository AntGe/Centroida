using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to find the second smallest element in an array. Go to the editor
//Test Data : 
//Input the size of array : 5 
//Input 5 elements in the array(value must be<9999) : 
//element - 0 : 0 
//element - 1 : 9 
//element - 2 : 4 
//element - 3 : 6 
//element - 4 : 5 
//Expected Output : 
//The Second smallest element in the array is : 4 
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
