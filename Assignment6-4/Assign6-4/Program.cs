﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6_4
{

    public delegate bool IsEven(int number);
    class Program
    {
        static void Main(string[] args)
        {

            IsEven e1 = (number) =>
            {

                return number % 2 == 0;

            };

            Console.WriteLine("Enter number : ");

            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("IsEvent : " + e1(temp));

            Console.ReadLine();
        }
    }
}