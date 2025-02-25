using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {
            //swithc 문

            //int day = 10;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    case 6:
            //        Console.WriteLine("토요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;

            //int iInput = 0;
            //Console.Write("캐릭터를 선택하세요 : (1.검사 2.마법사 3.도적) ");

            //iInput = int.Parse(Console.ReadLine());

            //        switch (iInput)
            //        {
            //            case 1:
            //                Console.WriteLine("검사");
            //                Console.WriteLine("공격력 100");
            //                Console.WriteLine("방어력 90");

            //        break;
            //            case 2:
            //                Console.WriteLine("마법사");
            //                Console.WriteLine("공격력 110");
            //                Console.WriteLine("방어력 80");
            //        break;
            //            case 3:
            //                Console.WriteLine("도적");
            //                Console.WriteLine("공격력 115");
            //                Console.WriteLine("방어력 70");
            //        break;


            //        }



            //반복문  


            //for(int i =1; i<=5; i++) //초기화, 조건문, 증감식
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}

            //for(int i =0; i<10; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}

            //int sum = 0;
            //for(int i =1; i<10; i++)
            //{
            //    sum = sum + i;

            //    Console.WriteLine($"sum : {sum} i : {1}");
            //}

            //Console.WriteLine("1부터 10까지의 합 : " + sum);

            //int count = 1;

            //while(count <= 5)
            //{
            //    Console.WriteLine("count : " + count);

            //    count++;

            //    if(count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }

            //}
            //Console.WriteLine("count : " + count);

            //Random rand = new Random();

            ////0이상 10 미만의 랜덤 정수 생성

            //int randomInRange = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    randomInRange = rand.Next(5, 15);
            //    Console.WriteLine("5부터 14까지 : " + randomInRange);


            //}

            //대장장이 키우기
            //도끼등급 sss 10%
            // ss 40%
            // s 50%

            //Random rand = new Random(); //랜덤값을 뽑는 문장

            //int rnd = 0;

            //for(int i=0; 1<20; i++)
            //{
            //    rnd = rand.Next(1, 101); //1~100

            //    if (rnd >= 1 && rnd <= 10) 
            //    {
            //        Console.WriteLine("도끼등급 sss");
            //    }
            //    else if (rnd >= 11 && rnd <= 40)
            //    {
            //        Console.WriteLine("도끼등급 ss");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼등급 s");
            //    }
            //    Thread.Sleep(300);
            //}



            //int x = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번은 실행");
            //    x--;
            //} while (x > 0);

            //break 문
            //반복문을 탈출

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //int n = 1;

            //start :

            //if(n <=5)
            //{
            //    Console.WriteLine(n);
            //    n++;


            //    goto start;
            //}








        }
    }
}


