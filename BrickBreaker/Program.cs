using System;
using System.Runtime.InteropServices;

namespace ShootingGame
{
    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;
        public Bullet[] playerBullet = new Bullet[20];
        public int Score = 0;

        public Player()
        {
            playerX = 35;
            playerY = 22;

            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new Bullet();
            }
        }

        public void KeyControl()
        {
            if (Console.KeyAvailable)
            {
                int pressKey = _getch();
                switch (pressKey)
                {
                    case 75: // 왼쪽
                        playerX = Math.Max(0, playerX - 1);
                        break;
                    case 77: // 오른쪽
                        playerX = Math.Min(75, playerX + 1);
                        break;
                    case 32: // 스페이스바 (총알 발사)
                        for (int i = 0; i < 20; i++)
                        {
                            if (!playerBullet[i].fire)
                            {
                                playerBullet[i].fire = true;
                                playerBullet[i].x = playerX;
                                playerBullet[i].y = playerY - 1;
                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void BulletDraw()
        {
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire)
                {
                    Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);
                    Console.Write("|");
                    playerBullet[i].y--;
                    if (playerBullet[i].y < 0) playerBullet[i].fire = false;
                }
            }
        }

        public void PlayerDraw()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("A");
        }
    }

    public class Enemy
    {
        public int enemyX;
        public int enemyY;
        public Bullet[] enemyBullets = new Bullet[10];
        Random rand = new Random();

        public Enemy()
        {
            enemyX = 35;
            enemyY = 2;
            for (int i = 0; i < 10; i++)
            {
                enemyBullets[i] = new Bullet();
            }
        }

        public void Respawn()
        {
            enemyX = rand.Next(0, 75);
        }

        public void EnemyDraw()
        {
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write("V");
        }

        public void Fire()
        {
            for (int i = 0; i < 10; i++)
            {
                if (!enemyBullets[i].fire)
                {
                    enemyBullets[i].fire = true;
                    enemyBullets[i].x = enemyX;
                    enemyBullets[i].y = enemyY + 1;
                    break;
                }
            }
        }

        public void BulletDraw()
        {
            for (int i = 0; i < 10; i++)
            {
                if (enemyBullets[i].fire)
                {
                    Console.SetCursorPosition(enemyBullets[i].x, enemyBullets[i].y);
                    Console.Write("|");
                    enemyBullets[i].y++;
                    if (enemyBullets[i].y > 23) enemyBullets[i].fire = false;
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Player player = new Player();
            Enemy enemy = new Enemy();
            int frame = 0;

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write($"Score: {player.Score}");

                player.KeyControl();
                player.PlayerDraw();
                player.BulletDraw();

                if (frame % 30 == 0) enemy.Fire();
                enemy.EnemyDraw();
                enemy.BulletDraw();

                // 플레이어 총알과 적 충돌 검사
                for (int i = 0; i < 20; i++)
                {
                    if (player.playerBullet[i].fire &&
                        player.playerBullet[i].x == enemy.enemyX &&
                        player.playerBullet[i].y == enemy.enemyY)
                    {
                        player.Score += 100;
                        enemy.Respawn();
                        player.playerBullet[i].fire = false;
                    }
                }

                // 적 총알과 플레이어 충돌 검사 (게임 오버)
                for (int i = 0; i < 10; i++)
                {
                    if (enemy.enemyBullets[i].fire &&
                        enemy.enemyBullets[i].x == player.playerX &&
                        enemy.enemyBullets[i].y == player.playerY)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(35, 12);
                        Console.Write("Game Over!");
                        Console.SetCursorPosition(35, 14);
                        Console.Write($"Final Score: {player.Score}");
                        Console.ReadKey();
                        return;
                    }
                }

                System.Threading.Thread.Sleep(100);
                frame++;
            }
        }
    }
}
