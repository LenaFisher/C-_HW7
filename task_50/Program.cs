// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7->такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int countRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int countColumn = Convert.ToInt32(Console.ReadLine());

const int ROWS = 4;
const int COLUMNS = 3;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

if (countRow > ROWS || countColumn > COLUMNS)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    int[,] ourMatrix = CreateMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
    PrintMatrix(ourMatrix);
    Console.WriteLine(ourMatrix[countRow, countColumn]);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(leftRange, rightRange);
    }
    return matrix;
}
