using System;
using System.Collections.Generic;
//must add this above  generic namespace
namespace ConsoleApp3generics
{
    class Program
    {
        static void Main(string[] args)
        {
            

            classa<int> a1 = new classa<int>();
            classa<char> b1 = new classa<char>();
            classa<double> c1 = new classa<double>();

            Console.WriteLine("please enter the choice of checking equality operation ");
            Console.WriteLine("enter 1 for int");
            Console.WriteLine("enter 2 for string");
            Console.WriteLine("enter 3 for double");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            switch (choice)
            {

                case 1:
                    int number1, numbr2;
                    Console.WriteLine("enter first integer type value");
                    number1 =Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("enter second integer type value");
                    numbr2 = Convert.ToInt32(Console.ReadLine());
                    a1.checkequality(number1, numbr2);
                    bool c = a1.checkequality(number1, numbr2);
                    if (c)
                    {
                        Console.WriteLine("equal");
                        Console.Read();
                    }
                    else 
                    {
                        Console.WriteLine("notequal");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    break;

                case 2:
                    char char1, char2;
                    Console.WriteLine("enter two char type value");
                    char1 = Convert.ToChar(Console.ReadLine());
                    char2 = Convert.ToChar(Console.ReadLine());
                    b1.checkequality(char1, char2);
                    bool d = a1.checkequality(char1, char2);
                    if (d)
                    {
                        Console.WriteLine("equal");
                        Console.Read();
                    }
                    else 
                    {
                        Console.WriteLine("notequal");
                        Console.ReadKey();
                    }

                    Console.ReadKey();
                    break;

                case 3:
                    double double1, double2;
                    Console.WriteLine("enter two double type value");
                    double1 = Convert.ToDouble(Console.ReadLine());
                    double2 = Convert.ToDouble(Console.ReadLine());
                    c1.checkequality(double1, double2);
                    bool e = c1.checkequality(double1, double2);
                    if (e)
                    {
                        Console.WriteLine("equal");
                        Console.Read();
                    }
                    else 
                    {
                        Console.WriteLine("notequal");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;

                   
            }
        }
        public class classa<T>
        {
            public bool checkequality(T a, T b)
            {
                return a.Equals(b);


            }


        }
    }
}