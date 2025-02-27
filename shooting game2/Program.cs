using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shooting_game2
{
    class Program
    {
        static int screenWidth = 40;
        static int screenHeight = 15;
        static int playerX = 2, playerY = screenHeight / 2; // 플레이어 위치
        static int bulletX = -1, bulletY = -1; // 총알 좌표
        static int enemyX, enemyY;
        static bool isRunning = true;
        static int score = 0;
        static int enemyMoveCounter = 0;
        static int enemyMoveSpeed = 3; // 적 이동 속도

        static string[] playerShape = new string[]
        {
        //"->",
        "〓▶"
        };

        static void Main(string[] args)
        {
            Random rand = new Random();
            enemyX = screenWidth - 3; // 적이 오른쪽 끝에서 시작
            enemyY = rand.Next(0, screenHeight); // 적의 랜덤한 높이

            // 키 입력을 별도 스레드에서 처리
            Thread inputThread = new Thread(InputHandler);
            inputThread.Start();

            while (isRunning)
            {
                Draw();
                Update();
                Thread.Sleep(100); // 게임 속도 조절
            }

            Console.Clear();
            Console.WriteLine($"게임 오버! 최종 점수: {score}");
        }

        static void InputHandler()
        {
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    // 방향키로 플레이어 이동
                    if (key == ConsoleKey.UpArrow && playerY > 0)
                        playerY--;

                    if (key == ConsoleKey.DownArrow && playerY < screenHeight - 2)
                        playerY++;

                    // 스페이스바로 총알 발사
                    if (key == ConsoleKey.Spacebar && bulletX == -1)
                    {
                        bulletX = playerX + 3; // 총알은 플레이어 오른쪽에서 발사
                        bulletY = playerY + 0;
                    }
                }
            }
        }

        static void Draw()
        {
            Console.Clear();

            for (int y = 0; y < screenHeight; y++)
            {
                for (int x = 0; x < screenWidth; x++)
                {
                    bool drawn = false;

                    // 플레이어 그리기
                    for (int i = 0; i < playerShape.Length; i++)
                    {
                        if (y == playerY + i && x >= playerX && x < playerX + playerShape[i].Length)
                        {
                            Console.Write(playerShape[i][x - playerX]);
                            drawn = true;
                        }
                    }

                    // 적 그리기
                    if (!drawn && x == enemyX && y == enemyY)
                    {
                        Console.Write("♥");
                        drawn = true;
                    }

                    // 총알 그리기
                    if (!drawn && x == bulletX && y == bulletY)
                    {
                        Console.Write("-");
                        drawn = true;
                    }

                    if (!drawn)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"점수: {score}");
            Console.WriteLine("↑ ↓ : 이동 / SPACE : 발사");
        }

        static void Update()
        {
            // 총알 이동
            if (bulletX >= 0)
                bulletX++;

            // 적 이동 속도 조절
            enemyMoveCounter++;
            if (enemyMoveCounter >= enemyMoveSpeed)
            {
                enemyX--;
                enemyMoveCounter = 0;
            }

            // 총알이 적을 맞추면 점수 증가 & 적 리스폰
            if (bulletX == enemyX && bulletY == enemyY)
            {
                score++;
                bulletX = -1; // 총알 초기화

                Random rand = new Random();
                enemyX = screenWidth - 3;
                enemyY = rand.Next(0, screenHeight);
            }

            // 적이 왼쪽 끝에 도달하면 게임 오버
            if (enemyX <= 0)
                isRunning = false;

        }
    }
}
