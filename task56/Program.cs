/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int MinSumElem(int[,] matrix) {
    int lastSum = 0;
    int indexRowWithMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentSum = currentSum + matrix[i, j];
        }
        if(i == 0) lastSum = currentSum;
        if (currentSum < lastSum) {
            lastSum = currentSum;
            indexRowWithMinSum = i;
        } 
    }
    return indexRowWithMinSum;
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}