/* 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
Console.WriteLine("Спиральное заполнение матрицы 4 х 4");

int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Введите размерность квадратичной матрицы.");
Console.Write("m = n = ");
int m = int.Parse(Console.ReadLine()!);
int n = m;
int[,] userMatrix = new int[m, n];
FillMatrix(userMatrix);
PrintMatrix(userMatrix);

void FillMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0) - 1;
    int column = matrix.GetLength(1) - 1;
    int lengthOfNumbers = matrix.GetLength(0) * matrix.GetLength(1);

    // Сколько раз нужно пройти по кругу, чтобы заполнить матрицу?
    int count = 0;
    int iterator = 0;
    int value = 0;
    if (matrix.GetLength(0) % 2 == 0)
    {
        count = matrix.GetLength(0) / 2;
    }
    else
    {
        count = matrix.GetLength(0) / 2 + 1;
    }
    // Пока не закончится число повторов, выполнять следующие действия
    while (iterator != count)
    {
        int action = 0;
        // Обработчик последнего цикла при нечетной размерности матрицы
        if (iterator == count - 1 && matrix.GetLength(0) % 2 != 0)
        {   
            int i = count - 1;
            int j = i;
            matrix[i, j] = ++value;
        }
        else
        {   
            // Заполняем верхнюю строку
            if (action == 0)
            {
                int i = iterator;
                for (int j = iterator; j <= column - iterator; j++)
                {
                    matrix[i, j] = ++value;
                }
                action++;
            }
            // Заполняем правый столбец
            if (action == 1)
            {
                int j = column - iterator;
                for (int i = iterator + 1; i < row - iterator; i++)
                {
                    matrix[i, j] = ++value;
                }
                action++;
            }
            // Заполняем нижнюю строку
            if (action == 2)
            {
                int i = row - iterator;
                for (int j = column - iterator; j >= iterator; j--)
                {
                    matrix[i, j] = ++value;
                }
                action++;
            }
            // Заполняем левый столбец
            if (action == 3)
            {
                int j = iterator;
                for (int i = row - 1 - iterator; i > iterator; i--)
                {
                    matrix[i, j] = ++value;
                }
            }
        }

        iterator++;
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) 
            {
                Console.Write($"0{matrix[i, j]}   ");                
            } 
            else
            {
                Console.Write($"{matrix[i, j]}   ");
            }
        }
        Console.WriteLine();
    }
}
