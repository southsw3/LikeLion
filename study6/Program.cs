using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            float Ruin_Skill_Damage = 0.0f;
            float Card_Gage = 0.0f;
            float Ultimate_Damage = 0.0f;
            int Max_MP = 0;
            int Regain_MP = 0;
            int Nonfight_Regain_MP = 0;
            float Speed = 0.0f;
            float Speed_Riding = 0.0f;
            float Speed_Carrying = 0.0f;
            float Skill_Cool_Time = 0.0f;


            Console.Write("스킬 피해량을 입력하세요.");
            string Damage_input = Console.ReadLine();
            Ruin_Skill_Damage = float.Parse(Damage_input);

            Console.Write("카드 게이지 획득량을 입력하세요.");
            string Card_input = Console.ReadLine();
            Card_Gage = float.Parse(Card_input);

            Console.Write("각성기 피해를 입력하세요.");
            string Ultimate_input = Console.ReadLine();
            Ultimate_Damage = float.Parse(Ultimate_input);

            Console.Write("최대 마나를 입력하세요.");
            string MaxMP_input = Console.ReadLine();
            Max_MP = int.Parse(MaxMP_input);


            Console.Write("전투중 마나 회복량을 입력하세요.");
            string RegainMP_input = Console.ReadLine();
            Regain_MP = int.Parse(RegainMP_input);

            Console.Write("비전투중 마나 회복량을 입력하세요.");
            string NonfightRegainMP_input = Console.ReadLine();
            Nonfight_Regain_MP = int.Parse(NonfightRegainMP_input);






            Console.WriteLine($"루인 스킬 피해 : {Ruin_Skill_Damage:F1}%");
            Console.WriteLine($"카드 게이지 획득량 : {Card_Gage:F1}%");
            Console.WriteLine($"각성기 피해 : {Ultimate_Damage:F1}%");
            Console.WriteLine($"최대 마나 : {Max_MP:F1}%");
            Console.WriteLine($"전투중 마나 회복량 : {Regain_MP:F1}%");
            Console.WriteLine($"비전투중 마나 회복량 : {Regain_MP:F1}%");

        }
    }
}
