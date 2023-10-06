using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив (пример)
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int n = matrix.GetLength(0);
        int diagonalSum = 0;

        // Вычисляем сумму элементов побочной диагонали
        for (int i = 0; i < n; i++)
        {
            diagonalSum += matrix[i, n - 1 - i];
        }

        // Проверяем, оканчивается ли сумма на цифру 0
        bool endsWithZero = (diagonalSum % 10 == 0);

        if (endsWithZero)
        {
            Console.WriteLine("Сумма элементов побочной диагонали оканчивается на 0.");
        }
        else
        {
            Console.WriteLine("Сумма элементов побочной диагонали НЕ оканчивается на 0.");
        }
    }
}
