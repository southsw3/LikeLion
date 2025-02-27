using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inventory_shooting_game
{
    class Program
    {

        struct Item
        {
            public string name;
            public string type;
            public int quantity;

            //생성자
            public Item(string name, string type, int quantity)
            {
                this.name = name;
                this.type = type;
                this.quantity = quantity;
            }
                 //아이템 정보 출력
            public void PrintItem()
            {
                Console.WriteLine($"[이름: {name}, 종류: {type}, 개수: {quantity}]");
            }
        }

        class Inventory
        {
            private Item[] items;
            private int itemCount;

            //생성자(인벤토리 크기 설정)
            public Inventory(int size)
            {
                items = new Item[size];
                itemCount = 0;
            }

            //아이템 추가 함수
            public void AddItem(string name, string type, int quantity)
            {
                if (itemCount < items.Length)
                {
                    items[itemCount] = new Item(name, type, quantity);
                    itemCount++;
                    Console.WriteLine($" {name}({quantity}개) 추가됨!");
                }
                else
                {
                    Console.WriteLine(" 인벤토리가 가득 찼습니다!");
                }
            }

            // 아이템 제거 함수
            public void RemoveItem(string name)
            {
                for (int i = 0; i < itemCount; i++)
                {
                    if (items[i].name == name)
                    {
                        Console.WriteLine($" {items[i].name} 제거됨!");

                        // 마지막 아이템을 제거된 자리로 이동
                        items[i] = items[itemCount - 1];
                        itemCount--;

                        return;
                    }
                }
                Console.WriteLine($" {name}을 찾을 수 없습니다!");
            }

            // 인벤토리 출력 함수
            public void PrintInventory()
            {
                Console.WriteLine("\n===  현재 인벤토리 ===");
                if (itemCount == 0)
                {
                    Console.WriteLine(" 인벤토리가 비어 있습니다!");
                    return;
                }

                for (int i = 0; i < itemCount; i++)
                {
                    items[i].PrintItem();
                }


            }

            class Prog
            {
                static void Main(string[] args)
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Inventory inventory = new Inventory(5); // 5칸짜리 인벤토리 생성

                    // 아이템 추가
                    inventory.AddItem("포션", "소모품", 7);
                    inventory.AddItem("검", "무기", 1);
                    inventory.AddItem("방패", "방어구", 1);
                    inventory.AddItem("화살", "탄약", 9);
                    inventory.AddItem("열쇠", "기타", 2);
                    inventory.AddItem("활", "무기", 1); // 초과 추가 테스트

                    inventory.PrintInventory(); // 현재 인벤토리 출력

                    // 아이템 제거
                    inventory.RemoveItem("화살");
                    inventory.PrintInventory();

                    inventory.RemoveItem("마법지팡이"); // 없는 아이템 제거 테스트


                }

            }

        }
    }
}
