using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study26
{
    //class Warrior
    //{
    //    public string Name { get; set; }
    //    public int Score { get; set; }
    //    public int Strength { get; set; }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name : {Name}, Score : {Score}, Strength : {Strength}");
    //    }

    //    class Program
    //    {

    //        static void Main(string[] args)
    //        {
    //            ////Warrior warrior = new Warrior();
    //            ////warrior.Name = "전사";
    //            ////warrior.Score = 100;
    //            ////warrior.Strength = 80;

    //            ////warrior.DisplayInfo();

    //        }
    //    }
    //}

    class Program
    {
        static void Main()
        {
            //Console.WriteLine("정수를 입력하세요. ");

            //try
            //{
            //    string input = Console.ReadLine();
            //    int number = int.Parse(input);
            //    Console.WriteLine($"입력한 숫자: {number}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}


            //List<string> fruits = new List<string> { "사과", "바나나", "포도" };

            //foreach (var fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Queue<string> tasks = new Queue<string> ();

            //Console.WriteLine();

            //tasks.Enqueue("첫 번째 직업");
            //tasks.Enqueue("두 번째 직업");
            //tasks.Enqueue("세 번째 직업");

            //while (tasks.Count > 0)
            //{
            //    Console.WriteLine(tasks.Dequeue());
            //}

            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);

            //Console.WriteLine();

            //while (numbers.Count > 0)
            //{
            //    Console.WriteLine(numbers.Pop());
            //}

            //Console.Write("문자열을 입력하세요 : ");
            //string input = Console.ReadLine();

            //string upperCase = input.ToUpper();
            //Console.WriteLine($"대문자로 변환: {upperCase}");

            //string replaced = input.Replace("C#", "CSharp");
            //Console.WriteLine($"변경된 문자열 : {replaced}");

            //int length = input.Length;
            //Console.WriteLine($"문자열 길이 : {length}");


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("짝수 필터링 결과 : ");

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            int sum = numbers.Sum();
            Console.WriteLine($"\n 모든 숫자의 합: {sum}");

        }
    }
}
