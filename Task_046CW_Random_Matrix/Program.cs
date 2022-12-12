// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();
const int m = 3;
const int n = 4;

int[,] matrix = new int [m, n];

FillArray(matrix);
PrintArray(matrix);

void FillArray (int[,] mat)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(-100, 101);
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