using System;
using System.Collections.Generic;

namespace TEXTRPG
{
    public class INFO
    {
        public string strName;
        public int iAttack;
        public int iHp;
        public int iGold; // 골드 추가
    }

    public class Weapon
    {
        public string Name;
        public int AttackPower;
        public int Price;
    }

    public class Player
    {
        public INFO m_tInfo;
        public Weapon m_Weapon = null; // 장착한 무기

        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        public INFO GetINFO() { return m_tInfo; }
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }

        public void SelectJob()
        {
            m_tInfo = new INFO { iGold = 100 }; // 초기 골드 100 추가
            Console.WriteLine("직업을 선택하세요 (1. 팔라딘 2. 비숍 3. 섀도어) : ");
            int iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "팔라딘";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "비숍";
                    m_tInfo.iHp = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "섀도어";
                    m_tInfo.iHp = 85;
                    m_tInfo.iAttack = 13;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("================");
            Console.WriteLine("직업 이름 : " + m_tInfo.strName);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + (m_tInfo.iAttack + (m_Weapon?.AttackPower ?? 0)));
            Console.WriteLine("골드 : " + m_tInfo.iGold);
            Console.WriteLine("장착 무기 : " + (m_Weapon != null ? m_Weapon.Name : "없음"));
        }
    }

    public class Monster
    {
        public INFO m_tMonster;
        public int GoldReward; // 처치 시 주는 골드

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; }
        public void SetMonster(INFO tMonster, int gold) { m_tMonster = tMonster; GoldReward = gold; }
        public INFO GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 :  " + m_tMonster.iAttack);
        }
    }

    public class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;
        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();

                int iInput = int.Parse(Console.ReadLine());
                if (iInput == 4) break;
                if (iInput <= 3) { CreateMonster(iInput); Fight(); }
            }
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1: Create("초보몹", 30, 3, 10, out m_pMonster); break;
                case 2: Create("중수몹", 60, 6, 20, out m_pMonster); break;
                case 3: Create("고수몹", 90, 9, 30, out m_pMonster); break;
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, int gold, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO { strName = _strName, iHp = _iHp, iAttack = -_iAttack };
            pMonster.SetMonster(tMonster, gold);
        }

        public void Fight()
        {
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();
                Console.WriteLine("1. 공격 2. 도망 : ");
                int iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetINFO().iAttack + (m_pPlayer.m_Weapon?.AttackPower ?? 0));

                    if (m_pPlayer.GetINFO().iHp <= 0) { m_pPlayer.SetHp(100); break; }
                    if (m_pMonster.GetMonster().iHp <= 0)
                    {
                        m_pPlayer.m_tInfo.iGold += m_pMonster.GoldReward;
                        Console.WriteLine("몬스터 처치! 골드 획득: " + m_pMonster.GoldReward);
                        Console.ReadKey();
                        m_pMonster = null;
                        break;
                    }
                }
                if (iInput == 2) break;
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보자 필드 ");
            Console.WriteLine("2. 중급자 필드 ");
            Console.WriteLine("3. 고급자 필드 ");
            Console.WriteLine("4. 돌아가기 ");
        }
    }

    public class Shop
    {
        public static List<Weapon> Weapons = new List<Weapon>
        {
            new Weapon { Name = "C급 무기", AttackPower = 10, Price = 50 },
            new Weapon { Name = "B급 무기", AttackPower = 15, Price = 100 },
            new Weapon { Name = "A급 무기", AttackPower = 20, Price = 200 }
        };

        public static void OpenShop(Player player)
        {
            Console.WriteLine("=== 상점 ===");
            for (int i = 0; i < Weapons.Count; i++)
                Console.WriteLine($"{i + 1}. {Weapons[i].Name} | 공격력: {Weapons[i].AttackPower} | 가격: {Weapons[i].Price}골드");
            Console.WriteLine("4. 나가기");
            int choice = int.Parse(Console.ReadLine());
            if (choice >= 1 && choice <= 3 && player.m_tInfo.iGold >= Weapons[choice - 1].Price)
            {
                player.m_tInfo.iGold -= Weapons[choice - 1].Price;
                player.m_Weapon = Weapons[choice - 1];
                Console.WriteLine("무기 구매 완료!");
            }
            Console.ReadKey();
        }
    }
}
