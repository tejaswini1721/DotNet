﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6_2
{
    class Program
    {
        public delegate bool isGreater(int a, int b);
        static void Main(string[] args)
        {

            isGreater g1 = (a, b) =>
            {

                if (a > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            Console.WriteLine(g1(20, 30));

            Console.ReadLine();

        }
    }
}
