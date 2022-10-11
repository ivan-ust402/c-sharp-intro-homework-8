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

int[,] firstMatrix = new int[m, n];
FillMatrix(firstMatrix);
PrintMatrix(firstMatrix);

Console.WriteLine("Количество столбцов первой матрицы должно быть равно числу строк второй матрицы. Поэтому ");
Console.WriteLine("p = n");
int p = n;
Console.WriteLine("Введите количество столбцов второй матрицы.");

Console.Write("t = ");
int t = int.Parse(Console.ReadLine()!);


int[,] secondMatrix = new int[p, t];
FillMatrix(secondMatrix);
PrintMatrix(secondMatrix);







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
