using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput} ");
            //Console.WriteLine($"10진수로 변환 : {decimalValue} ");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부: {isStudent}");

            //int defalutInt = default; // 기본값 : 0
            //string defaultString = default; // 기본값 : null
            //bool defaultBool = default; // 기본값 : false

            //Console.WriteLine($"정수 기본값 : {defalutInt}");
            //Console.WriteLine($"문자열 기본값 : {defaultString}");
            //Console.WriteLine($"논리값 기본값 : {defaultBool}");

            //int a = 5, b = 3;

            //int sum = 0;

            //sum = a + b; //산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //sum = a - b; //산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //sum = a * b; //산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //sum = a / b; //산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //int c = 0, d = 0;

            //c = 2;
            //d = 5;
            //sum = c % d; //산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //int number = 7;

            //int sum = 0;

            //sum = number % 2;

            //Console.WriteLine("짝수 홀수 판별 :" + sum );


            //관계형 연산자
            //bool isEqual = false;

            //int a = 5;
            //int b = 5;

            //isEqual = (a == b);

            //Console.WriteLine("같은가? " + isEqual);

            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            //Console.WriteLine(!flag);

            //int num = 10;
            //int result = ~num;

            //Console.WriteLine("원래값 : " + num);
            //Console.WriteLine("~ 연산자 적용 후" + result);

            //double pi = 3.14;
            //int integerPi = (int)pi;

            //Console.WriteLine(integerPi);

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float  average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3;

            //Console.WriteLine("총점 : " + sum);
            //Console.WriteLine("평균 : " + average);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);


            //int a = 10;

            //a += 5; // a = a + 5
            //Console.WriteLine(a);
            //a -= 5; // a = a - 5
            //Console.WriteLine(a);
            //a *= 5; // a = a * 5
            //Console.WriteLine(a);
            //a /= 5; // a = a / 5
            //Console.WriteLine(a);
            //a %= 5; // a = a % 5
            //Console.WriteLine(a);

            //Console.WriteLine("국어 점수 입력 : ");
            //int Kor = int.Parse(Console.ReadLine());
            //Console.WriteLine("영어 점수 입력 : ");
            //int Eng = int.Parse(Console.ReadLine());
            //Console.WriteLine("수학 점수 입력 : ");
            //int Math = int.Parse(Console.ReadLine());

            //int sum = 0;
            //sum = Kor + Eng + Math;
            //float average = (float)sum / 3;

            //Console.WriteLine($"총점 : {sum} ");
            //Console.WriteLine($"평균 : {average.ToString("F2")} ");


            //Console.WriteLine("-----------------------------");

            //int input = int.Parse(Console.ReadLine());

            //int inverted = input;

            //Console.WriteLine($"입력한 정수 : {input}");
            //Console.WriteLine($"비트 반전 결과 : {inverted}");

            //int b = 3;

            //Console.WriteLine("b의 값은 : " + (++b));
            //Console.WriteLine("b의 값은 : " + (b));

            //Console.WriteLine("b의 값은 : " + (b--));

            //int x = 5, y = 10;

            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);

            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            //AND : 1 : 1 t  곱하기 느낌
            //      1 : 0 f
            //      0 : 1 f
            //      0 : 0 f
            //Console.WriteLine(a || b);
            //OR : 1 : 1 t    or은 더해준다고 생각
            //     1 : 0 t
            //     0 : 1 t
            //     0 : 0 f

            //True : 1 , False : 0

            //Not : 반대
            //!a

            //b = !a;

            //Console.WriteLine(b);

            //비트 연산자
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y); //AND
            //Console.WriteLine(x | y); //OR
            //Console.WriteLine(x ^ y); //XOR
            //Console.WriteLine(~x); //NOT : -6

            //int value = 4; //0100 2진수

            //Console.WriteLine(value << 1); //왼쪽 이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽 이동 : 2 (0010)

            //int a = 10, b = 20;

            //int max;

            //max = (a < b) ? a : b; //삼항 연산자

            //Console.WriteLine(max);

            // (비교) ? 참 : 거짓; (자체가 문법임)

            //int key = 1;

            //string str;
            //str = (key == 1) ? "문이열렸습니다." : "문을 열지 못했습니다.";

            //Console.WriteLine(str);

            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;

            //Console.WriteLine(adjustedResult);

            //int score = 90;

            //if(score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else
            //{
            //    Console.WriteLine("B학점");
            //}

            //string GameID = "냄비빙수";

            //if(GameID == "냄비빙수")
            //{
            //    Console.WriteLine("아이디가 일치합니다.");
            //}
            //else
            //{
            //    Console.WriteLine("아이디가 일치하지 않습니다.");
            //}

            //int score = 90;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}

            //가지고 있는 소지금을 입력하세요
            //0~100 무한의 대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6
            //601 넘어가면 전설의검 +7

            //2단계 출력
            //캐릭터 멋사검존
            //무기 : 가지고 있는 무기이름 표시하기
            //공격력 : 100 +1

            //int money = 0;
            //int AddAtt = 0;
            //string Weapon = "";
            //Console.WriteLine("가지고 있는 소지금을 입력하세요 : ");

            //money = int.Parse(Console.ReadLine());

            //if (money > 0 && money <= 100)
            //{
            //    Weapon = "무한의대검";
            //    AddAtt = 1;
            //}
            //else if (money >= 101 && money <= 200)
            //{
            //    Weapon = "카타나";
            //    AddAtt = 2;
            //}
            //else if (money >= 201 && money <= 300)
            //{
            //    Weapon = "진은검";
            //    AddAtt = 3;
            //}
            //else if (money >= 301 && money <= 400)
            //{
            //    Weapon = "집판검";
            //    AddAtt = 4;
            //}
            //else if (money >= 401 && money <= 500)
            //{
            //    Weapon = "엑스칼리버";
            //    AddAtt = 5;
            //}
            //else if (money >= 501 && money <= 600)
            //{
            //    Weapon = "유령검";
            //    AddAtt = 6;
            //}
            //else
            //{
            //    Weapon = "전설의검";
            //    AddAtt = 7;
            //}

            //Console.WriteLine("캐릭터 멋사검존");
            //Console.WriteLine("무기 : " + Weapon);
            //Console.WriteLine("공격력 : 100 + " + AddAtt);

            //Console.Write("첫 번째 정수를 입력하세요 : ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("두 번째 정수를 입력하세요 : ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("세 번째 정수를 입력하세요 : ");
            //int num3 = int.Parse(Console.ReadLine());

            //int max = num1;

            //if (num2 > max)
            //{
            //    max = num2;
            //}
            //if (num3 > max)
            //{
            //    max = num3;
            //}

            //Console.WriteLine($"최댓값 : {max}");

            //Console.WriteLine();

            //Console.Write("학점을 입력하세요 : ");
            //int Grade = int.Parse(Console.ReadLine());

            //if (Grade >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else if (Grade >= 80)
            //{
            //    Console.WriteLine("B학점");
            //}
            //else if (Grade >= 70)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else if (Grade >= 60)
            //{
            //    Console.WriteLine("D학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}

            //int result = 0;
            //Console.WriteLine("정수를 입력하시오 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("연산자 기호를 입력하시오 : ");
            //string oper = (Console.ReadLine());
            //Console.WriteLine("정수를 입력하시오 : ");
            //int num2 = int.Parse(Console.ReadLine());

            //if (oper == "+")
            //    result = num1 + num2;
            //else if (oper == "-")
            //    result = num1 = num2;
            //else if (oper == "*")
            //    result = num1 * num2;
            //else if (oper == "/")
            //{
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("오류: 0으로 나눌 수 없습니다.");
            //        return;
            //    }
            //    result = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("오류: 지원하지 않는 연산자입니다.");
            //    return;
            //}
            //Console.WriteLine("결과 : " + result);


            // 정수형 변수 a를 선언하고 값 10을 저장합니다.

        }





























    }
    }
