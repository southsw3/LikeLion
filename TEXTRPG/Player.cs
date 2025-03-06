using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Player
    {
        public INFO m_tInfo;
        public int Gold { get; private set; } = 0; // 골드 추가

        // 데미지를 입는 함수
        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        public INFO GetINFO() { return m_tInfo; }
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }

        // 골드 추가 함수
        public void AddGold(int amount) { Gold += amount; }

        public void SelectJob()
        {
            m_tInfo = new INFO();

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
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + m_tInfo.iAttack);
            Console.WriteLine("골드 : " + Gold); 
        }

        public Player() { }
        ~Player() { } // 소멸자
    }
}
