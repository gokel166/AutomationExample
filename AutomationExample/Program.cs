using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class MathExecute
    {
        public int AdditionFunction(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int SubtractionFunction(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
