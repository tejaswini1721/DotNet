﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6_5
{

    public delegate bool IsGreaterThan(decimal basic);
    class Program
    {

        static void Main(string[] args)
        {

            IsGreaterThan g1 = (basic) =>
            {
                if (basic > 10000)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            Console.WriteLine("Enter Basic : ");

            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("IsGreaterThan 10000 : " + g1(temp));

            Console.ReadLine();

        }
    }
}
