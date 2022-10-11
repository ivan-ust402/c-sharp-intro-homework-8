/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Матрицы должны быть согласованы, т.е. число столбцов первой матрицы 
Должно быть равно числу строк второй
*/
Console.Clear();
Console.WriteLine("Введите количество строк и столбцов первой матрицы.");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов первой матрицы должно быть ");
Console.WriteLine("равно числу строк второй матрицы.");
Console.WriteLine($"Поэтому p = n = {n}");
int p = n;
Console.WriteLine("Введите количество столбцов второй матрицы.");

Console.Write("t = ");
int t = int.Parse(Console.ReadLine()!);

int[,] firstMatrix = new int[m, n];
FillMatrix(firstMatrix);
PrintMatrix(firstMatrix, "Первая матрица: ");

int[,] secondMatrix = new int[p, t];
FillMatrix(secondMatrix);
PrintMatrix(secondMatrix, "Вторая матрица: ");

int[,] finishMatrix = MultiplyMatrices(firstMatrix, secondMatrix);
PrintMatrix(finishMatrix, "Результирующая матрица: ");

int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix) {
    int[,] multMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum = sum + firstMatrix[i, k] * secondMatrix[k, j];
            }
            multMatrix[i, j] = sum;
        }
    }
    return multMatrix;
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

void PrintMatrix(int[,] matrix, string nameOfMatrix)
{   
    Console.WriteLine();
    Console.WriteLine(nameOfMatrix);
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
