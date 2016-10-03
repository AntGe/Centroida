using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
