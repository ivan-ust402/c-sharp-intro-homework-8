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

int[,,] array3D = new int[x, y, z];

void FillArray3D(int[,,] array) {
    Random randomGen = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = randomGen.Next(10, 100);
            }
        }
    }
}

void 