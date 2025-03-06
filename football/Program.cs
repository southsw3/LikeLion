using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    class FbPlayer
    {
        public string Name;
        public string Shoot;
        public string Ceremony;

        public FbPlayer()
        {
            Name = "Unknown";
            Shoot = "Unknown";
            Ceremony = "Unknown";
        }

        public virtual void ball(FbPlayer target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 슛을 합니다.");
        }

        public virtual void ceremony(FbPlayer target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 세레머니를 합니다.");
        }
    }

    class Ronaldo : FbPlayer
    {
        public Ronaldo()
        {
            Name = "Ronaldo";
            Shoot = "Shoot";
            Ceremony = "siuuuu";
        }

        public override void ball(FbPlayer target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 슛을 찹니다.");
        }

        public override void ceremony(FbPlayer target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 세레머니 {Ceremony}를 합니다!");
        }
    }

    class Messi : FbPlayer
    {
        public Messi()
        {
            Name = "Messi";
            Shoot = "Shoot";
            Ceremony = "유니폼 던지기";
        }

        public override void ball(FbPlayer target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 슛을 찹니다.");
        }

        public override void ceremony(FbPlayer target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}에게 세레머니 {Ceremony}를 합니다!! ");
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<FbPlayer> FbPlayers = new List<FbPlayer>
            {
                new Ronaldo(),
                new Messi()
            };

                
                for (int i = 0; i < FbPlayers.Count - 1; i++)
                {
                    FbPlayers[i].ball(FbPlayers[i + 1]);
                    FbPlayers[i].ceremony(FbPlayers[i + 1]);
                    Console.WriteLine();
                    FbPlayers[i + 1].ball(FbPlayers[i]);
                    FbPlayers[i + 1].ceremony(FbPlayers[i]);
                }

            }
        }
    }
}