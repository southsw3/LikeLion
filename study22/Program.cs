using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;

namespace study22
{
    class Program
    {

        //클래스시그니처 기본구성
        //c#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

        //[접근 지정자] [수정자] class 클래스 이름 : 부모클래스, 인터페이스
        //public  abstract                       : BaseClass , IComparable
        //private sealed
        //protected static
        //          partial

        public class Player
        {
            public string Name { get; set; }
                public int Score { get; set; }
        }
        //상속하는 클래스
        public class Warrior : Player
        {
            public int Strength { get; set; }
        }
        //인터페이스 구현하는 클래스
        //public class Enemy : IAttackable, IMovable
        //{
        //    public void Attack() { }
        //    public void Move() { }
        //}
        //추상 클래스 (abstract
        public abstract class Animal
        {
            public abstract void MakeSound();
        }


        static void Main(string[] args)
        {

            //Console.WriteLine("프로그램 종료");
            //string path = Environment.GetEnvironmentVariable("PATH");
            //Environment.Exit(0);

            //Random random = new Random();

            //int randomNumber = random.Next(0, 100);
            //Console.WriteLine("랜덤 숫자 : " + randomNumber);

            //프로그램 실행 시간 구하기

            //Stopwatch stopwatch = Stopwatch.StartNew();

            ////실행코드
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1);
            //}
            ////0.001

            //stopwatch.Stop();

            //Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");


            //string input = "Hello, my phone number is 010-5555-5555";
            //string pattern = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴

            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"전화번호가 존재하는가? {isMatch} ");

         

        }
    }
}
