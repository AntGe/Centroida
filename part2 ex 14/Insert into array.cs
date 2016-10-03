using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# Sharp to insert New value in the array (unsorted list ). Go to the editor
//Test Data : 
//Input the size of array : 4 
//Input 4 elements in the array in ascending order: 
//element - 0 : 1 
//element - 1 : 8 
//element - 2 : 7 
//element - 3 : 10 
//Input the value to be inserted : 5 
//Input the Position, where the value to be inserted :2 
//Expected Output : 
//The current list of the array : 
//1 8 7 10 
//After Insert the element the new list is : 
//1 5 8 7 10 
namespace part2_ex_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size of array :");
            int arrSize = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(arrSize);
            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine("element " + i.ToString() + " :");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Input the values to be input : ");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position (starting from 0: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Before input");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Insert(position, inputNumber);
            Console.WriteLine("After input");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
