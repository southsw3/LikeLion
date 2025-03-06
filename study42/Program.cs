using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("간단한 RPG 게임을 시작합니다.");

            //캐릭터 생성
            GameCharacter warrior = new Warrior("전사");
            GameCharacter mage = new Mage("마법사");

            Console.WriteLine("======전투시작=======");

            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);


        }
    }
}
