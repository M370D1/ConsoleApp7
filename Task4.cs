﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Task4
    {
        public class MathOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b, double c)
            {
                return a + b + c;
            }

            public decimal Add(decimal a, decimal b, decimal c)
            {
                return a + b + c;
            }
        }
        public static void Execute()
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m)); 
        }
    }
}
