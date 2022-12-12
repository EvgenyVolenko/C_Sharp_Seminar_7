// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

Console.Clear();
const int m = 5;
const int n = 6;

int[,] matrix = new int [m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма значений главной диагонали матрицы равна {SumMainDiag(matrix)}");

int SumMainDiag (int[,] table)
{   
    int maxCount = table.GetLength(0);
    int minCount = table.GetLength(1);
    Console.WriteLine($"В массиве {maxCount} строк {minCount} столбцов");
    int sum = 0;
    if (maxCount < minCount) minCount = maxCount;
    for (int i = 0; i < minCount; i++) 
    {
        sum = sum + table[i, i];
    }
    return sum;
}

void FillArray (int[,] mat)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Переходим по столбцам
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}