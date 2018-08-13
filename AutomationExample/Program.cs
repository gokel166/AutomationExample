using System;
using System.Net;

namespace AutomationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 45;
            
            Console.WriteLine(AdditionFunc(a, b));
            Console.ReadLine();
        }

        // Addition Function
        public static int AdditionFunc(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }


    
}
