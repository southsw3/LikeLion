using System;
using System.Collections.Generic;
using System.Threading;

class ConsoleSnakeGame
{
    static int width = 40, height = 20;
    static int foodX, foodY;
    static List<(int, int)> snake = new List<(int, int)> { (5, 5) };
    static string direction = "RIGHT";
    static bool gameOver = false;
    static Random rand = new Random();
    static char[,] buffer = new char[height, width];

    static void Main()
    {

        Console.CursorVisible = false; // 커서 숨기기
        int centerX = (Console.WindowWidth / 2) - 3; // 가운데 정렬
        int centerY = Console.WindowHeight / 2; // 세로 중앙

        string[] loadingSteps = { "□□□□□", "■□□□□", "■■□□□", "■■■□□", "■■■■□", "■■■■■" };

        foreach (string step in loadingSteps)
        {
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(step);
            Thread.Sleep(1000);
            Console.Clear();
        }

        Console.SetCursorPosition(centerX, centerY);
        Console.WriteLine("로딩완료!");
        Thread.Sleep(1000);
        Console.Clear();

        Console.CursorVisible = false;
        Thread inputThread = new Thread(ReadInput);
        inputThread.Start();
        PlaceFood();

        while (!gameOver)
        {
            MoveSnake();
            Render();
            Thread.Sleep(200);
        }
        Console.Clear();
        Console.WriteLine("Game Over! Score: " + (snake.Count - 1));
    }

    static void ReadInput()
    {
        while (!gameOver)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.W && direction != "DOWN") direction = "UP";
                else if (key == ConsoleKey.S && direction != "UP") direction = "DOWN";
                else if (key == ConsoleKey.A && direction != "RIGHT") direction = "LEFT";
                else if (key == ConsoleKey.D && direction != "LEFT") direction = "RIGHT";
            }
        }
    }

    static void MoveSnake()
    {
        (int x, int y) head = snake[0];
        int newX = head.x, newY = head.y;

        if (direction == "UP") newX--;
        else if (direction == "DOWN") newX++;
        else if (direction == "LEFT") newY--;
        else if (direction == "RIGHT") newY++;

        if (newX < 0 || newX >= height || newY < 0 || newY >= width || snake.Contains((newX, newY)))
        {
            gameOver = true;
            return;
        }

        snake.Insert(0, (newX, newY));
        if (newX == foodX && newY == foodY)
            PlaceFood();
        else
            snake.RemoveAt(snake.Count - 1);
    }

    static void PlaceFood()
    {
        bool validPosition = false;
        while (!validPosition)
        {
            foodX = rand.Next(height);
            foodY = rand.Next(width);
            if (!snake.Contains((foodX, foodY)))
                validPosition = true;
        }
    }

    static void Render()
    {
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                buffer[i, j] = '.';
            }
        }

        foreach (var (x, y) in snake)
        {
            buffer[x, y] = 'O';
        }
        buffer[foodX, foodY] = 'X';

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(buffer[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Score: " + (snake.Count - 1));
    }
}
