using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study30
{
    //업캐스팅
    //자식 클래스 -> 부모클래스로 변환하는것
    //암시적 변환이 가능
    //안전: 데이터 손실 없이 변환가능
    //다운캐스팅
    //명시적 변환이 필요
    //불완전함 -> 실행중 InvalidCastException 발생가능
    //as 또는 is 키워드로 안전하게 변환가능
    class Animal //부모 클래스
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog(); //자식 클래스 객체 생성
            //Animal myAnimal = myDog; //업캐스팅

            //myAnimal.Speak();

            //myAnimal.Bark(); 오류 업캐스팅 후 자식 클래스의 메서드는 접근 불가


            Animal myAnimal = new Dog();
            Dog myDog = (Dog)myAnimal;

            myDog.Bark();

            //Animal myANIMAL12 = new Animal();
            //Dog myDog = (Dog)myAnimal12;

            if(myAnimal is Dog myDog1)
            {
                myDog1.Bark();
            }
            else
            {
                Console.WriteLine("변환할 수 없습니다.");
            }

            Dog myDog = myAnimal as Dog;




        }
    }
}
