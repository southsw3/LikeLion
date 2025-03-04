using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace study25
{
    class program
    {
        //public T Content { get; set; }

        static void Main(string[] args)
        {
            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString : {cupOfString.Content}");
            //Console.WriteLine($"CupOfInput : {cupOfInt.Content}");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //ArrayList list = new ArrayList { "Apple", "Banna", "Cherry" };
            //IEnumerator enumerator = list.GetEnumerator();

            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}


            //int? nullableInt = null;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No Value");

            ////null 값을 다루는 연산자 소개하기 ?? , ? . 연산자
            ////?? 연산자를 사용해 null인 경우 대체값을 제공하고, ?.은 null안전 접근을 합니다.

            //string str = null;

            //Console.WriteLine(str ?? "DefaultValue"); //str이 null이면 "Default Value"

            //str = "Hello";

            //Console.WriteLine(str?.Length);


            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach(var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            string str = null;

            Console.WriteLine(str ?? "DefaultValue");

            if (str != null)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("DefaultValue");
            }

        }


    }
}
