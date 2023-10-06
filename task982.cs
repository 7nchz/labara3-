using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите порядок магического квадрата (нечетное число): ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Порядок квадрата должен быть нечетным.");
            return;
        }

        int[,] magicSquare = new int[n, n];

        int row = 0;
        int col = n / 2;

        for (int num = 1; num <= n * n; num++)
        {
            magicSquare[row, col] = num;

            int nextRow = (row - 1 + n) % n;
            int nextCol = (col + 1) % n;

            if (magicSquare[nextRow, nextCol] != 0)
            {
                row = (row + 1) % n;
            }
            else
            {
                row = nextRow;
                col = nextCol;
            }
        }

        Console.WriteLine("Магический квадрат порядка " + n + ":");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(magicSquare[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
