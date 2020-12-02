using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {

        static void oldMain()
        {

            //System.Console.WriteLine("Hello World");
            //System.Console.ReadLine();
            //Console.WriteLine("Hello teju");
            //Console.ReadLine();

            //DataSet ds = new DataSet();
        }
        static void Main()
        {

            Class1 o;   //o is reference of type Class1
            o = new Class1();   //allocate memory for any object of Type Class1 and make o point to it
            o.Display();
            o.Display("Umesh");

            //Addition
            Console.WriteLine("Addition of Numbers");
            o.add(3, 2, 5);
            o.add2(d: 9);
            Console.WriteLine(o.add(5, 2));
            Console.WriteLine(o.add2(d: 9));


            //Subtraction
            Console.WriteLine("Subtraction of Numbers");
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            o.sub(num1, num2);
            Console.ReadLine();

            //Multiplication
            Console.WriteLine("Multiplication of Numbers");
            Console.WriteLine("Enter number 1");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num4 = Convert.ToInt32(Console.ReadLine());

            o.mul(num3, num4);
            Console.ReadLine();


            //Different class

            Class2 o1;   //o is reference of type Class2
            o1 = new Class2(10, 20);   //allocate memory for any object of Type Class2 and make o point to it
            //Division
            Console.WriteLine("Division of Numbers");
            Console.WriteLine("Enter number 1");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num6 = Convert.ToInt32(Console.ReadLine());


            o1.Div(num5, num6);
            Console.ReadLine();


        }
    }
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Hello Display");

        }
        //Function overloading
        public void Display(String s)
        {
            Console.WriteLine("Hello Display" + " " + s);

        }
        public int add(int a, int b)
        {
            return a + b;

        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine("Addition is" + " " + (a + b + c));

        }



        public int add2(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            return a + b + c + d;

        }




        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction is" + " " + (a - b));

        }

        public void mul(int a, int b)
        {
            Console.WriteLine("Multiplication is" + " " + (a * b));

        }
    }


    public class Class2
    {
        int x = 10;
        int y = 9;
        public Class2(int a, int b)
        {
            a = x;
            b = y;
            Console.WriteLine("Constructor is called");
            add(a, b);

        }

        public void add(int a, int b)
        {
            Console.WriteLine("Addition is" + " " + (a + b));
        }


        public void Div(int c, int d)
        {
            Console.WriteLine("Division is" + " " + (int)(c / d));
        }

    }
}
