using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# Sharp program that takes distance and time as input and display the speed in kilometers per hour and miles per hour. Go to the editor
//Test Data:
//Input distance(meters): 50000 
//Input timeSec(hour): 1 
//Input timeSec(minutes): 35
//Input timeSec(seconds): 56
//Expected Output:
//Your speed in meters/sec is 8.686588
//Your speed in km/h is 31.27172 
//Your speed in miles/h is 19.4355
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
