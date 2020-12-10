﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6_1
{
    public delegate decimal SimpleInterest(decimal P, decimal N, decimal R);
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest s1 = (P, N, R) =>
            {

                return P * R * N / 100;
            };

            Console.WriteLine("Enter P :");
            decimal pri = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter N : ");
            decimal re = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter R : ");
            decimal ne = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Simple Interest is : " + s1(pri, re, ne));

            Console.ReadLine();
        }
    }
}
