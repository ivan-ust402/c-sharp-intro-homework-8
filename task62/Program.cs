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

int[] array = new int[]{01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16};
int[,] matrix = new int[4,4];
FillMatrix(matrix, array);
PrintMatrix(matrix);

void FillMatrix(int[,] matrix, int[] array) {
    int row = matrix.GetLength(0) - 1;
    int column = matrix.GetLength(1) - 1;
    int lengthOfNumbers = matrix.GetLength(0) * matrix.GetLength(1);

    // Сколько раз нужно пройти по кругу, чтобы заполнить матрицу?
    int count = 0;
    int iterator = 0;
    int index = 0;
    if (matrix.GetLength(0) % 2 == 0) {
        count = matrix.GetLength(0) / 2;
    }
    else {
        count = matrix.GetLength(0) / 2 + 1;
    }
    // Пока не закончится число повторов, выполнять следующие действия
    while(iterator != count + 1) {
        // int maxValueOfOneIteration = 
        for (int i = iterator; i < matrix.GetLength(0) - iterator; i++)
        {
            for (int j = iterator; j < matrix.GetLength(1) - iterator; j++)
            {
                // Заполняем верхнюю строку
                if (i == iterator && j >= iterator) {
                    matrix[i, j] = array[index++]; 
                }
                // Заполняем правый столбец
                else if (i > iterator && j == column - iterator && i < row - iterator) {
                    matrix[i, j] = array[index++];
                }
                // Заполняем нижнюю строку
                else if (i == row - iterator && j <= column - iterator) {
                    matrix[i, column - j] = array[index++]; 
                }
                // Заполняем левый столбец
                else if (i > iterator && j == iterator && i < row - iterator) {
                    matrix[row - i, j] = array[index++]; 
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
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}
