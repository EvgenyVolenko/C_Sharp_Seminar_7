// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет

Console.Clear();
const int m = 3;
const int n = 4;

int[,] matrix = new int [m, n];

FillArray(matrix);
PrintArray(matrix);

Console.Write("Введите номер строки для поиска элемента: ");
int stroka = vvod();
Console.Write("Введите номер столбца для поиска элемента: ");
int stolbec = vvod();

if (CheckKoord(stroka, stolbec) == true) 
{
    Console.WriteLine($"Элемент массива в строке {stroka} в столбце {stolbec} = {matrix[stroka, stolbec]}.");
}
else Console.WriteLine("Числа с такими координатами в массиве нет!");

bool CheckKoord (int str, int stolb)
{
    return (str < matrix.GetLength(0) && stolb < matrix.GetLength(1));
}

int vvod()
{
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit))
        {
            if (digit >= 0) break;
            else Console.Write("Нужно ввести число >= 0: ");
        }
        else Console.Write("Ну просил же число! ");
    }
    return digit;
}

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