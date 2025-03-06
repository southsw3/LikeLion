using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study39
{

    //ref 포인터개념 참조
    //메서드 ref, out
    
    class Program
    {
        //static void Increase(ref int x)
        //{
        //    x++;
        //}

        //out은 반환이 여러 개 일때 유용함
        static void Increase2(out int x)
        {
            x = 10;
        }

        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            //Increase(ref a);

            //Console.WriteLine("A의 값 : " + a);
            int x, y;
            OutFunc(a, b, out x, out y);

            Console.WriteLine(" x : " + x + " y : " + y);

           
        }
    }
}
