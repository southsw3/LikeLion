using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Field
    {
        Player m_pPlayer = null;
        //몬스터
        Monster m_pMonster = null;

        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, int _gold, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = -_iAttack;

            pMonster.SetMonster(tMonster, _gold);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, 10, out m_pMonster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, 20, out m_pMonster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, 30, out m_pMonster);
                    break;
            }
        }

        public void Fight()
        {
            int iIput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1. 공격 2. 도망 : ");
                iIput = int.Parse(Console.ReadLine());

                if (iIput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetINFO().iAttack);

                    if (m_pPlayer.GetINFO().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }
                if (iIput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    if (m_pMonster.GetMonster().iHp <= 0)
                    {
                        m_pPlayer.AddGold(m_pMonster.GoldReward);
                        Console.WriteLine($"{m_pMonster.GetMonster().strName}을 처치하여 {m_pMonster.GoldReward} 골드를 획득했습니다!");
                    }
                    m_pMonster = null;
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 1-(1~10) ");
            Console.WriteLine("2. 1-(11~20) ");
            Console.WriteLine("3. 1-(21~30) ");
            Console.WriteLine("4. 전단계 ");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
