// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrix()
{
    int side = 4;
    int[,] matrix = new int[side, side];
    int num = 1,
        column = side,
        row = side,
        zeroColumn = 0,
        zeroRow = 0;
    while (zeroColumn < column)
    {
        for (int i = zeroColumn; i < column; i++)
        {
            matrix[zeroRow, i] = num++;
        }
        column --;
        for (int j = zeroRow + 1; j < row; j++)
        {
            matrix[j, row - 1] = num++;
        }
        row --;
        for (int k = column - 1; k >= zeroColumn; k--)
        {
            matrix[column, k] = num++;
        }
        for (int l = row - 1; l > zeroRow; l--)
        {
            matrix[l, zeroColumn] = num++;
        }
        zeroColumn++;
        zeroRow++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j], 3}");
        Console.WriteLine();
    }
}

PrintMatrix(FillMatrix());