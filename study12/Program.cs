using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study12
{
    class Program
    {
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //static int AddArrow(int a, int b) => a + b;

        //static void PrintMessage()
        //{
        //    Console.WriteLine("안녕하세요");
        //}
        //static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(3, 5));
            //Console.WriteLine(AddArrow(3, 5));

            //PrintMessage();
            //PrintMessageArrow();

            Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");

        }
    }
}
