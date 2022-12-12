// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;
const int m = 3;
const int n = 4;

double[,] matrix = new double [m, n];

FillArray(matrix, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix);
Console.WriteLine($"Средние арифметические элементов в каждом столбце [{string.Join("| ", RaschetSrednihZnachStolbec(matrix))}]");

double[] RaschetSrednihZnachStolbec (double[,] table)
{
    int stolbs = table.GetLength(1);
    int stroks = table.GetLength(0);
    double sum;
    double[] srednie = new double [stolbs];
    for (int i = 0; i < stolbs; i++)
    {
        sum = 0;
        for (int j = 0; j < stroks; j++)
        {
            sum = sum + table[j, i];
        }
        srednie[i] = Math.Round(sum / Convert.ToDouble(stroks), 1, MidpointRounding.AwayFromZero);
    }
    return srednie;
}

void FillArray (double[,] mat, int leftRange, int rightRange)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
}

void PrintArray(double[,] matr)
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