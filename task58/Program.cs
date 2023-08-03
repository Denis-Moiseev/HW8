int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк матриц: ");
int columns = GetInput("Введите количество столбцов матриц: ");
int[,] matrix1 = Create2DArray(rows, columns, 1, 4);
int[,] matrix2 = Create2DArray(rows, columns, 1, 4);
Console.WriteLine("Первая матрица:");
Print2DArray(matrix1);
Console.WriteLine("Вторая матрица:");
Print2DArray(matrix2);
int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
Console.WriteLine("Произведение двух матриц:");
Print2DArray(resultMatrix);