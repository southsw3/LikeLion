﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace study35
{
    class Skill
    {
        public string Name;
        public int ManaCost;
        public int Cooldown;
        public int LastUsedTime;

        public Skill(string name, int manaCost, int cooldown)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000;
            LastUsedTime = 0;
        }
        //스킬 사용 가능 여부 확인
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;

            if (playerMana < ManaCost)
            {
                Console.WriteLine($" 마나가 부족합니다. (필요 MP : {ManaCost} ");
                return false;
            }

            if (currentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($" {Name} 스킬은 아직 사용할 수 없습니다. (남은 시간 : {remainingTime}초) ");
                return false;
            }
            return true;
        }

        //스킬 사용
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;

            playerMana -= ManaCost; //플레이어 마나 참조로 외부 값도 같이 조정 동기화
            LastUsedTime = Environment.TickCount; //현지 시간을 저장

            Console.WriteLine($"{Name} 스킬 사용 (MP - {ManaCost})");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int playerMana = 200; //플레이어의 초기 마나

            //스킬 목록 (배열 사용)
            Skill[] skills = new Skill[]
            {
                new Skill("파이어볼", 20, 3), //마나 20 소모 3초 쿨다운
                new Skill("얼음창", 15, 2), //마나 15 소모 2초 쿨다운
                new Skill("힐링", 30, 5), //마나 30 소모 5초 쿨다운
            };


            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP : {playerMana}");
                Console.WriteLine("사용 가능한 스킬 : ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP {skills[i].ManaCost} "
                        + $", 쿨다운 {skills[i].Cooldown / 1000}s)");
                }
                    Console.WriteLine("0. 종료");
                    Console.WriteLine("사용할 스킬 번호를 입력하세요 : ");

                    try
                    {
                        int skillIndex = int.Parse(Console.ReadLine());

                        if (skillIndex == 0) break;

                        if (skillIndex > 0 && skillIndex <= skills.Length)
                        {
                            skills[skillIndex - 1].Use(ref playerMana);
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("숫자를 입력하세요!");
                    }

                    Thread.Sleep(500);

                
                Console.WriteLine("게임종료");


            }
        }
    }
}
