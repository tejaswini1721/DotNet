﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6_3
{

    public delegate decimal GetBasic(decimal basic);
    class Program
    {
        static void Main(string[] args)
        {
            GetBasic g1 = (basic) =>
            {
                return basic;
            };

            Console.WriteLine("Basic salary is : " + g1(12000));

            Console.ReadLine();

        }
    }

}