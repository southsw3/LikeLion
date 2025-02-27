using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;


namespace 모험가_키우기
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();
            //멋사 4기는 능력이 사기다
            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;
            int playerHP = 100;  // 플레이어 체력
            int monsterHP = 100; // 몬스터 체력
            int round = 1;       // 라운드 수

            Console.WriteLine(" ⚔️ 모험가 키우기 ⚔️ ");
            Thread.Sleep(1000);

            while (isAlive)
            {


                if (input == 1)  //탐험하기
                {

                    Console.WriteLine("⚔️ 자동 전투 시뮬레이션 시작! ⚔️\n");

                }
                Console.WriteLine($"🔄 Round {round} 🔄");

                int playerAttack = rand.Next(5, 11);  // 기본 공격력 (5~10)
                int monsterAttack = rand.Next(5, 11); // 기본 공격력 (5~10)

                // 20% 확률로 추가 데미지 (5~10)
                if (rand.Next(0, 10) < 6)  // 0~4 중 0일 때 추가 공격 (30% 확률)
                {
                    Thread.Sleep(800);
                    int extraDamage = rand.Next(5, 11);
                    playerAttack += extraDamage;
                    Console.WriteLine($"🔥 플레이어가 추가 공격! +{extraDamage} 데미지!");
                }

                if (rand.Next(0, 10) < 3)  // 30% 확률로 몬스터도 추가 데미지
                {
                    Thread.Sleep(800);
                    int extraDamage = rand.Next(5, 11);
                    monsterAttack += extraDamage;
                    Console.WriteLine($"💀 몬스터가 추가 공격! +{extraDamage} 데미지!");
                }

                // 공격 적용
                monsterHP -= playerAttack;
                playerHP -= monsterAttack;

                Thread.Sleep(800);
                Console.WriteLine($"🧑‍🚀 플레이어가 {playerAttack}의 데미지를 입혔습니다! (몬스터 체력: {Math.Max(monsterHP, 0)})");
                Console.WriteLine($"👹 몬스터가 {monsterAttack}의 데미지를 입혔습니다! (플레이어 체력: {Math.Max(playerHP, 0)})\n");

                // 다음 라운드 진행 (엔터 입력)
                Console.WriteLine("➡️ 다음 라운드로 진행하려면 [Enter] 키를 누르세요...");
                Console.ReadLine();
                Console.Clear();

                round++;
            }

            // 승패 판정
            if (playerHP <= 0 && monsterHP <= 0)
                Console.WriteLine("⚖️ 무승부! ⚖️");
            else if (playerHP > 0)
                Console.WriteLine("🎉 플레이어 승리! 🎉");
            else
                Console.WriteLine("💀 몬스터 승리! 💀");
        }
    }
}
