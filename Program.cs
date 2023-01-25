//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите индекс строки элемента: ");
int rowIndex = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите индекс столбца элемента: ");
int columnsIndex = int.Parse(Console.ReadLine() ?? "");

Console.Clear();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

CheckArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void CheckArray(int[,] matrix)
{
    if (rowIndex < array.GetLength(0) && columnsIndex < array.GetLength(1))
    {
        Console.WriteLine($"{rowIndex} {columnsIndex} -> {array[rowIndex, columnsIndex]}");
    }
    else
    {
        Console.WriteLine($"{rowIndex} {columnsIndex} -> Такого числа нет");
    }
}