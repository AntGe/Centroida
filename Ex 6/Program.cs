﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  x = y2 + 2y + 1  = :");
            for (int i = -5; i <= 5; i++)
            {
                int y = i;
                Console.WriteLine(Math.Pow(y,2) + 2 * y + 1);
               
            }
        }
    }
}
