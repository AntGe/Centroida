using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part3_ex7
{
    class Program
    {
        static double Raise(double numer, double raise)
        {
            return Math.Pow(numer, raise);
            
        }
        static void Main()
        {
            Console.WriteLine("Enter number :");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter power :");
            double power = double.Parse(Console.ReadLine());
            double raised = Raise(number, power);
            Console.WriteLine("Raised :" + raised);
            
            
        }
    }
}
