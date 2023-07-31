// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    // Console.WriteLine();
    return matrix;
}

void MultiMatrix(int[,] resultArray, int[,] array1, int[,] array2)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("Матрица №1:");
int[,] array1 = CreateMatrix(2, 2);

Console.WriteLine("Матрица №2:");
int[,] array2 = CreateMatrix(2, 2);

Console.WriteLine("Произведение матриц:");
int[,] resultArray = new int[2, 2];
MultiMatrix(resultArray, array1, array2);
PrintMatrix(resultArray);
