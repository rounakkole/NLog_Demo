// See https://aka.ms/new-console-template for more information
using System;

namespace NLog_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Logger Demo");

            AddNumbers obj = new AddNumbers();
            obj.Sum(2, 3);
        }
    }
}
