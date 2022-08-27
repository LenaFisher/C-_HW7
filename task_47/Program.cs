// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = CreateMatrix(m, n, 0, 10);
PrintMatrix(ourMatrix);

double[,] CreateMatrix(int rows, int columns, double leftRange, double rightRange)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.NextDouble();
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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
