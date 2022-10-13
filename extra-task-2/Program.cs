/* 
Доп задача 2. Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/
Console.Clear();
Console.Write("Введите количество строк треугольника паскаля: ");
int rows = int.Parse(Console.ReadLine()!);
int[,] paskalTriangle = PaskalTriangle(rows);
PrintMatrix(paskalTriangle);

int Factorial(int number) {
    int x = 1;
    for (int i = 1; i <= number; i++)
    {
        x = x * i;
    }
    return x;
}

int[,] PaskalTriangle(int rows) {
    int[,] resultMatrix = new int[rows, rows];
    for (int i = 0; i < rows; i++)
    {   
        for (int j = i; j <= i; j++)
        {
            resultMatrix[i, j] = Factorial(i) / (Factorial(j) * Factorial(i - j));
        }
    }
    return resultMatrix;
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