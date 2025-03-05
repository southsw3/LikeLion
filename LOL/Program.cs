using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL
{
    class Champion
    {
        public string Name;
        protected int Health;

        public Champion()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack(Champion target)
        {
            Console.WriteLine($" {Name}이(가) {target.Name}에게 기본 공격을 합니다.");
        }

        public virtual void Heal(Champion target)
        {
            Console.WriteLine($"{Name}은 치명타 공격을 할 수 없습니다.");
        }


    }
    //마스터이 챔피언(고정데미지와 치유)
    class MasterYi : Champion
    {
        public MasterYi()
        {
            Name = "MasterYi";
            Health = 250;
        }

        public override void Attack(Champion target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 우주류 검술로 공격합니다. (고정데미지)");
        }

        public override void Heal(Champion target)
        {
            Console.WriteLine($"{Name}가 자가 치유합니다.");
        }

    }

    class Ezreal : Champion
    {
        public Ezreal()
        {
            Name = "Ezreal";
            Health = 200;

        }
        public override void Attack(Champion target)
        {
            Console.WriteLine($"Ezreal이(가) {target.Name}에게 신비한 화살을 발사합니다. ");
        }

        public override void Heal(Champion target)
        {
            Console.WriteLine($"{Name}이(가) 자가치유를 할 수 없습니다.");
        }

    }
    
    class Soraka : Champion
    {
        public Soraka()
        {
            Name = "Soraka";
            Health = 150;
        }

        public override void Heal(Champion target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}을(를) 치유합니다.");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            List<Champion> Champions = new List<Champion>();

            Champions.Add(new MasterYi());
            Champions.Add(new Ezreal());
            Champions.Add(new Soraka());

            foreach (var Champion in Champions)
            {
                // 자신이 아닌 다른 챔피언을 공격하도록 설정
                Champion target = Champions.Find(c => c != Champion);

                // 예외 방지: 대상이 없으면 자기 자신을 지정
                if (target == null) target = Champion;

                Champion.Attack(target);
                Champion.Heal(Champion);
                Console.WriteLine();
            }
            MasterYi masterYi = new MasterYi();
            masterYi.Attack(Champions[1]); // 0번 MasterYi, 1번 Ezreal이므로 Ezreal 공격
            masterYi.Heal(Champions[0]); // MasterYi 스스로 치유

            Console.WriteLine();
            Ezreal ezreal = new Ezreal();
            ezreal.Attack(Champions[0]); // Ezreal이 MasterYi 공격

            Soraka soraka = new Soraka();
            soraka.Heal(Champions[1]);

            Console.ReadLine();


        }
    }
}
