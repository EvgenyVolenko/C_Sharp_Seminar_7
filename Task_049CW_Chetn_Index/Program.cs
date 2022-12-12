// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Clear();
const int m = 6;
const int n = 4;

int[,] matrix = new int [m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindChetnIndexAndReplace(matrix);
PrintArray(matrix);

void FindChetnIndexAndReplace (int[,] table)
{
    for (int i = 1; i < table.GetLength(0); i += 2) // Переходим по строкам
    {
        for (int j = 1; j < table.GetLength(1); j += 2) // Переходим по столбцам
        {
            table[i, j] = table[i, j] * table[i, j];
        }
    }
}

void FillArray (int[,] mat)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(0, 11);
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
