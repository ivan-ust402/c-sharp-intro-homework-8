/* 
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();
Console.WriteLine("Введите размерность трехмерного массива.");
Console.Write("x = ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("y = ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("z = ");
int z = int.Parse(Console.ReadLine()!);

if (x > 4 && y > 4 && z > 4)
{
    Console.WriteLine("В связи с ограничением диапазона значений вводимых элементов в матрицу (числа от 10 до 99) матрица не может быть больше 4 х 4 х 4, для работы с бОльшими матрицами необходимо программно расширить диапазон");
}
else if (x < 0 && y < 0 && z < 0)
{
    Console.WriteLine("Размерность матрицы не может быть отрицательной!");
}
else
{
    int[,,] array3D = new int[x, y, z];
    FillArray3D(array3D);
    PrintArray3D(array3D);
    Console.WriteLine("Форматирование вывода матрицы как в примере к заданию");
    PrintArray3DHowInExample(array3D);
}

void FillArray3D(int[,,] array)
{
    Random randomGen = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = randomGen.Next(10, 100);
                // Console.WriteLine($"Main {number}");
                bool notInArray = NotInArray(array, number);
                if (notInArray)
                {
                    // Console.WriteLine($"В if {number}");
                    array[i, j, k] = number;
                }
                else
                {
                    while (!notInArray)
                    {
                        number = randomGen.Next(10, 100);
                        notInArray = NotInArray(array, number);
                    }
                    // Console.WriteLine($"В else {number}");
                    array[i, j, k] = number;
                }

            }
        }
    }
}

bool NotInArray(int[,,] array, int number)
{
    int count = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int p = 0; p < array.GetLength(2); p++)
            {
                if (number == array[m, n, p])
                {
                    count++;
                }
            }
        }
    }
    if (count > 0) return false;
    else return true;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Console.WriteLine($"x = {i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void PrintArray3DHowInExample(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Console.WriteLine($"x = {i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({j}, {k}, {i}) ");
            }
            Console.WriteLine();
        }
    }
}