﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace project_대장장이
{
    class Program
    {
        static void Main(string[] args)
        {

            //랜덤
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);

            while (true)
            {
                Console.Clear(); //화면 지우기
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 달기

                if (input == 1)
                {
                    while (true)
                    {

                        Console.WriteLine("나무캐기(엔터");
                        Console.WriteLine("뒤로가기 (x) ");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }

                    }
                }
                else if (input == 2)
                {
                    //장비뽑기
                    if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기
                        for (int i = 1; 1 <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1)
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");

                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(100);

                        }

                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. ");
                        Thread.Sleep(1000);

                    }

                }
                else if (input == 3)
                {
                    Console.WriteLine("게임종료. ");
                    Environment.Exit(0);
                }

            }


        }
    }
}
