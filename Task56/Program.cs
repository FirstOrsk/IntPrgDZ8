// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

void MinRow(int[,] matrix)
{
    int sumRow = 0,
        minSumRow = 0,
        numMinSumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        minSumRow += matrix[0, j];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow += matrix[i, j];
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            numMinSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numMinSumRow + 1}");
}

int[,] array = CreateMatrix(4, 4);
MinRow(array);
