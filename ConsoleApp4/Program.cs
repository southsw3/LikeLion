using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        struct Student
        {
            public string name;
            public int korean;
            public int english;
            public int math;

            // 생성자
            public Student(string name, int korean, int english, int math)
            {
                this.name = name;
                this.korean = korean;
                this.english = english;
                this.math = math;
            }

            // 학생 정보 출력 메서드
            public void PrintInfo()
            {
                Console.WriteLine($"이름: {name}, 국어: {korean}, 영어: {english}, 수학: {math}");
            }
        }

        class Program
        {
            static void Main()
            {
                // 학생 3명 생성
                Student s1 = new Student("철수", 90, 85, 88);
                Student s2 = new Student("영희", 75, 95, 80);
                Student s3 = new Student("민수", 88, 76, 92);

                // 학생 정보 출력
                s1.PrintInfo();
                s2.PrintInfo();
                s3.PrintInfo();
            }
        }

    }
