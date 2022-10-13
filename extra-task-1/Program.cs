/* 
Доп задача 1. Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
*/
Console.Clear();
Console.WriteLine("Введите количество строк и столбцов массива.");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
int[] indeces = FindIndeces(matrix);
PrintArray(indeces);
int[,] resultMatrix = DeleteColumnsAndRows(matrix, indeces);
PrintMatrix(resultMatrix);

int[] FindIndeces(int[,] matrix)
{
    int minValue = matrix[0, 0];
    int[] array = new int[2];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minValue > matrix[i, j])
            {
                minValue = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    array[0] = row;
    array[1] = column;
    return array;
}

int[,] DeleteColumnsAndRows(int[,] matrix, int[] array)
{
    int[,] temp = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            temp[i, j] = matrix[i, j];
        }
    }
    for (int i = array[0]; i < temp.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[i, j] = matrix[i + 1, j];
        }
    }

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            resultMatrix[i, j] = temp[i, j];
        }
    }
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = array[1]; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = temp[i, j + 1];
        }
    }
    return resultMatrix;
}

void FillMatrix(int[,] matrix)
{
    Random randomGen = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = randomGen.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    Console.WriteLine("Индексы первого минимального числа:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"i = {array[i]}   ");
        }
        else
        {
            Console.Write($"j = {array[i]}   ");
        }
    }
    Console.WriteLine();
}