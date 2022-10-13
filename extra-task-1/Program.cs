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
int[] arrayOfIndeces = FindIndecesOfMinValues(matrix);
PrintArray(arrayOfIndeces);



int[] FindIndecesOfMinValues(int[,] matrix) {
    int minValue = matrix[0, 0];
    int[] arrayOfindeces = new int[2];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minValue > matrix[i, j]) {
                minValue = matrix[i, j];
            } 
        }
    }

    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minValue == matrix[i, j]) {
                count++;
            } 
        }
    }

    int[] resultArray = new int[count * 2];
    int index = 0;
    while(count != 0) {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (minValue == matrix[i, j]) {
                    resultArray[index] = i;
                    resultArray[++index] = j;
                    count--;
                    index++;
                } 
            }
        }
    }

    return resultArray;
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

void PrintArray(int[] array)
{       
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}