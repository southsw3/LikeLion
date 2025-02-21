using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting;
            //greeting = "hello, world!";

            //Console.WriteLine(greeting);

            //변수 선언과 초기화를 한번에 수행
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.6; //실수형 변수 선언과 초기화
            //string city = "Seoul"; //문자열 변수 선언과 초기화

            //Console.WriteLine(score);
            // Console.WriteLine(temperature);
            //Console.WriteLine("city");

            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double pi = 3.14159;
            //const int MaxScore = 100;


            //Console.WriteLine("pi : " +pi);
            //Console.WriteLine("MaxScore : " + MaxScore);

            int att = 16755;
            int maxhp = 78103;
            int stat1 = 36;
            int stat2 = 1017;
            int stat3 = 41;
            int stat4 = 611;
            int stat5 = 22;
            int stat6 = 39;

            Console.WriteLine("기본특성");
            Console.WriteLine("공격력:" + att);
            Console.WriteLine("최대생명력:" + maxhp);
            Console.WriteLine();
            Console.WriteLine("전투특성");
            Console.WriteLine("치명:" + stat1);
            Console.WriteLine("특화:" + stat2);
            Console.WriteLine("제압:" + stat3);
            Console.WriteLine("신속:" + stat4);
            Console.WriteLine("인내:" + stat5);
            Console.WriteLine("숙련:" + stat6);



        }
    }
}
