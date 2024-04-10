using System;

namespace DotNetDesignPatterns
{
    class Program
    {
        private static int Add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is : "+Add(a,b));
            Console.ReadLine();
        }
    }
}