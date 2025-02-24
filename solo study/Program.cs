using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solo_study
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. 리터럴
            //int num = 10; 정수형 리터럴
            //double pi = 3.14; 실수형 리터럴
            //char letter = 'A' 문자형 리터럴
            //String name = "Alice" 문자열 리터럴

            //캐릭터
            //hp: 100
            //att: 56.7
            //캐릭터이름 : ??
            //등급 : S

            //int hp = 100;
            //float att = 56.7f;
            //string Name = "김빵빵";
            //char grade = 'S';

            //Console.WriteLine("Name :" +"김빵빵");
            //Console.WriteLine("hp :" + 100);
            //Console.WriteLine("att :" +56.7);
            //Console.WriteLine("grade :" + 'S');

            //3. 문자열
            //Console.WriteLine("3.문자열");
            //string greeting; //문자열 변수 선언
            //greeting = "Hello, World";  //greeting이란: 변수에 값을 저장하는 것

            //Console.WriteLine(greeting);

            //4. 변수 선언과 초기화를 한번에 수행
            //int score = 100; //정수형 변수 선언과 동시에 100으로초기화
            //double temperature = 35.4; //실수형 변수 선언과 초기화
            //string city = "Seoul"; //문자열 변수 선언과 초기화

            //Console.WriteLine(score);
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);


            //5. 형식이 같은 변수 여러 개를 한번에 선언하기
            //int x = 10, y = 20, z = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //6.상수 사용하기
            //Console.WriteLine("Pi = " + 3.14);
            //Console.WriteLine("MaxScore = " + 100);

            //int 공격력 = 1555;
            //int MaxHP = 78000;
            //int stat1 = 36;
            //int stat2 = 1111;
            //int stat3 = 41;
            //int stat4 = 55;
            //int stat5 = 66;
            //int stat6 = 77;

            //Console.WriteLine("기본특성");
            //Console.WriteLine("공격력 = " + 1555);
            //Console.WriteLine("MaxHP = " + 78000);
            //Console.WriteLine();
            //Console.WriteLine("전투특성");
            //Console.WriteLine("stat1 = " + 36);
            //Console.WriteLine("stat2 = " + 1111);
            //Console.WriteLine("stat3 = " + 41);
            //Console.WriteLine("stat4 = " + 55);
            //Console.WriteLine("stat5 = " + 66);
            //Console.WriteLine("stat6 = " + 77);

            //7. 숫자 데이터 형식
            //int integerNum = 10; //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수 float은 뒤에 f를 붙여야 함
            //double doubleNum = 3.14159; //배정밀도 실수

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            //19. 문자열 입력 관련 메서드
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine($"안녕하세요, {userName}님!");
            //Console.Write("나이를 입력하세요 : ");
            //string age = Console.ReadLine();

            Console.Write("루인 스킬 피해 입력 값을 입력하세요 : ");
            string stat1 = Console.ReadLine();
            float nStat1 = float.Parse(stat1);
            Console.Write("카드 게이지 획득량의 입력 값을 입력하세요 : ");
            string stat2 = Console.ReadLine();
            float nStat2 = float.Parse(stat2);
            Console.Write("각성시 피해 입력 값을 입력하세요 : ");
            string stat3 = Console.ReadLine();
            float nStat3 = float.Parse(stat3);
            Console.Write("최대 마나 입력 값을 입력하세요 : ");
            string stat4 = Console.ReadLine();
            int nStat4 = int.Parse(stat4);
            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            string stat5 = Console.ReadLine();
            int nStat5 = int.Parse(stat5);
            Console.Write("비전투 중 마나 회복량을 입력하세요 : ");
            string stat6 = Console.ReadLine();
            int nStat6 = int.Parse(stat6);
            Console.Write("이동속도를 입력하세요 : ");
            string stat7 = Console.ReadLine();
            float nStat7 = float.Parse(stat7);
            Console.Write("탈 것 속도를 입력하세요 : ");
            string stat8 = Console.ReadLine();
            float nStat8 = float.Parse(stat8);
            Console.Write("운반 속도를 입력하세요 : ");
            string stat9 = Console.ReadLine();
            float nStat9 = float.Parse(stat9);
            Console.Write("스킬 재사용 대기시간 감소 입력값을 입력하세요 : ");
            string stat10 = Console.ReadLine();
            float nStat10 = float.Parse(stat10);

            Console.WriteLine("|n" + "=====" + "|n");

            Console.WriteLine("루인 스킬 피해 : " + nStat1 + "%");
            Console.WriteLine("카드 게이지 획득량 : " + nStat2 + "%");
            Console.WriteLine("각성기 피해 : " + nStat3 + "%");
            Console.WriteLine("최대 마나 : " + nStat4);
            Console.WriteLine("전투 중 마나 회복량 : " + nStat5);
            Console.WriteLine("비전투 중 마나 회복량 : " + nStat6);
            Console.WriteLine("이동 속도 : " + nStat7 + "%");
            Console.WriteLine("탈 것 속도 : " + nStat8 + "%");
            Console.WriteLine("운반 속도 : " + nStat9 + "%");
            Console.WriteLine("스킬 재사용 대기시간 감소 : " + nStat10 + "%");




        }
    }
}
