using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study40
{
    //추상클래스 (Abstarct Class)?
    //추상클래스는 객체를 생성할 수 없는 클래스로, 상속을 통해서만 사용할 수 있다.
    //공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제
    //abstarct 키워드 사용
    //추상 메서드는 선언만 하고, 구현은 X
    //상속받은 클래스는 반드시 구현해야 하낟.

    //추상 메서드(구현, 상속받은 클래스가 구현)
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다.");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("야옹!");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound(); //멍멍
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();
        }
    }
}
