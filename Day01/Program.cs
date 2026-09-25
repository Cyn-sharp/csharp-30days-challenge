using System;

namespace Day1
{
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        static void Main()
        {
            MyMethod("Cyndrick", 16);
            MyMethod("Rusty", 18);
            MyMethod("Hezelle", 18);
        }
    }
}