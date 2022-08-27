// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); //количество строк
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
int[,] ourMatrix = GetMatrix(m, n, 0, 10);
PrintMatrix(ourMatrix);
CalcMatrix(ourMatrix);


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CalcMatrix(int[,] matrix)
{
    Console.WriteLine();

    string result = "";
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        result = result + ((float)temp / matrix.GetLength(0)) + ", ";
    }
    Console.Write(result);
}