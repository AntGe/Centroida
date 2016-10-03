using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance:");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours");
            double timeH = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            double timeM = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconds");
            double timeS = double.Parse(Console.ReadLine());
            Console.WriteLine("Speed = :");
            double mPS = distance / ((timeH * 3600) + (timeM * 60) + timeS);
            Console.WriteLine(mPS);
            Console.WriteLine(mPS * 3.6);
            Console.WriteLine((mPS * 3.6) / 1.609344);
        }
    }
}
