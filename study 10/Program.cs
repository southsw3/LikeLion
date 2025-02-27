using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace study_10
{
    class Program
    { //static int Add(int a, int b)
      //{
      //  return a + b;
      //}
        //static int StringLength(string input)
        //{
          //  return input.Length;
        //}

        static int Getmax(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;

            return max;
        }

        static void Main(string[] args)
        {
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            //int[] numbers = new int[5];
            //int sum = 0;

            //Console.WriteLine("5개의 정수를 입력하세요:");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"숫자 {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine()); 
            //    sum += numbers[i]; 
            //}


            //Console.WriteLine($"입력한 숫자의 합: {sum}");


            //int[] numbers = { 3, 8, 15, 6, 2 };


            //int max = numbers[0];


            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}


            //Console.WriteLine($"최대값: {max}");

            //for (int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int num = 1;
            //while (num <10)
            //{
            //    if (num % 2 ==0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //    num++;
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.Write("첫 번째 숫자를 입력하세요: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("두 번째 숫자를 입력하세요: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = Add(num1, num2);
            //Console.WriteLine($"{num1}과 {num2}의 합: {result}");


            //Console.Write("문자열 입력 : ");
            //string Input = Console.ReadLine();

            //int length = StringLength(Input);
            //Console.WriteLine($"문자열 길이 : {length}");

            Console.WriteLine("첫 번째 숫자 입력 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("첫 번째 숫자 입력 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("첫 번째 숫자 입력 : ");
            int num3 = int.Parse(Console.ReadLine());

            int max = Getmax(num1, num2, num3);
            Console.WriteLine($"가장 큰 수 :{max}");



        }
    }
}


