﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_3a
{

    public class Employee
    {
        int empno;
        string empname;
        string designation;
        int age;

        public Employee(int empno, string empname, string designation, int age)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.age = age;
        }

        public override string ToString()
        {
            return empno + " " + empname + " " + designation + " " + age;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the how many employee you want : ");
            int size = int.Parse(Console.ReadLine());
            Employee[] e1 = new Employee[size];

            for (int i = 0; i < e1.Length; i++)
            {
                Console.WriteLine("\nEnter empno : ");
                int no = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter empname: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter designation : ");
                string design = Console.ReadLine();

                Console.WriteLine("Enter age : ");
                int age = int.Parse(Console.ReadLine());

                Employee e = new Employee(no, name, design, age);

                e1[i] = e;

            }

            // for(int i =0;i<e1.Length;i++)
            //{
            //    Console.WriteLine(e1[i]);
            //}


            Console.WriteLine("\nDeatils of employee after converstion");

            List<Employee> list = new List<Employee>(e1);

            foreach (Employee li in list)
            {
                Console.WriteLine(li);
            }


            Console.ReadLine();

        }
    }
}
