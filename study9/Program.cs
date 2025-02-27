using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            //0부터 시작하는게 가장 중요.

            //int[] num = new int[3]; //3개 메모리 만들겠다 

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //for (int i = 0; 1 < 3; i++) 
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 }; //간단한 선언과 초기화
            //int[] numbers2 = new int[3]; //크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

            //for(int i =0; i<3; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for(int i =0; i<3; i++)
            //{
            //    Console.WriteLine(fruits[i]);

            //}


            //int[] iKor = new int[3];
            //int[] iEng = new int[3];
            //int[] iMth = new int[3];

            //int[] sum = new int[3];
            //float[] average = new float[3];

            //for (int i = 0; i < 3; i++)
            //{


            //    Console.WriteLine("학생의 성적을 입력하세요 ");
            //    Console.Write("국어 : ");
            //    iKor[0] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 : ");
            //    iEng[1] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 : ");
            //    iMth[2] = int.Parse(Console.ReadLine());

            //    sum[i] += iKor[i] + iEng[i] + iMth[i];

            //    average[i] = (float)sum[i] / 3;


            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine((i + 1) + "번학생");
            //    Console.WriteLine($"국어 :{iKor[i]}  영어 : {iEng[i]} 수학 : {iMth[i]}");
            //    Console.WriteLine("총점 : " + sum[i]);
            //    Console.WriteLine("평균 : " + average[i].ToString("F2");

            //}

            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for(int i =0; 1<scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {1 + 1}:{scores[1]}");
            //}

            //double value = 123.456789;
            ////소수점 자리수 설정하는 포맷
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점둘째자리 : {value:F2}");
            //Console.WriteLine(String.Format("소수점 둘째 자리: {0:F2}",value));

            //Console.WriteLine(value.ToString("F0"));

            //double value = 132231213.123;
            //Console.WriteLine(value.ToString("N2"));

            //2차원 배열 선언
            //int[,] matrix = new int[2, 3] //박스 3개짜리가 2개
            //{
            //    {1,2,3},{4,5,6}
            //};

            //for(int i=0; i<2; i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.WriteLine($"{matrix[i, j]"};

            //    }
            //     Console.WriteLine();




            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };



            //for (int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}




            //int[][] matrix = new int[2][];

            //matrix[0] = new int[3];
            //matrix[1] = new int[3];

            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;

            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            //for(int i =0; 9<matrix.Length; i ++)
            //{
            //    for(int j=0; j < matrix[i].Length; j++)
            //    {
            //        Console.WriteLine(matrix[i][j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //6. 가변배율
            //Console.WriteLine("가변 배열");
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");







        }
    }
}
