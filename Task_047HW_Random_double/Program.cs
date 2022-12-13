// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​m = 3, n = 4.
// ​0,5 7 -2 -0,2
// ​1 -3,3 8 -9,9
// ​8 7,8 -7,1 9

Console.Clear();
const int m = 4;
const int n = 4;
const int startRand = -10;
const int endRand = 10;

double[,] matrix = new double [m, n];

FillArray(matrix, startRand, endRand);
PrintArray(matrix);

double RandomForFill (int max, int min)
{   
    Random rand = new Random();
    double digit = min + rand.NextDouble() * (max - min);
    return digit;    
}

void FillArray (double[,] mat, int st, int en)
{
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = RandomForFill(st, en);
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Переходим по столбцам
        {
            Console.Write($"{matr[i, j]:f2} | "); // :f2 выводит на печать только 2 символа после запятой.
        }
        Console.WriteLine();
    }
}