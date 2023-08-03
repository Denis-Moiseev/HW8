void ShowRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        minSum += array[0, k];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            minRow = i + 1;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {minRow}");
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
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

int[,] array = Create2DArray(4, 4, 1, 9);
Console.WriteLine("Задан массив: ");
Print2DArray(array);
ShowRowMinSumElements(array);