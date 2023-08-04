void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:00} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] Create2DSpiralArray(int n)
{
    int[,] array = new int[n, n];
    int currentNum = new Random().Next(1, 84);
    int maxNum = (currentNum - 1) + (n * n);
    int rowStart = 0, rowEnd = n - 1;
    int columnStart = 0, columnEnd = n - 1;
    while (currentNum <= maxNum)
    {
        for (int i = columnStart; i <= columnEnd; i++)
        {
            array[rowStart, i] = currentNum++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, columnEnd] = currentNum++;
        }
        columnEnd--;
        for (int i = columnEnd; i >= columnStart; i--)
        {
            array[rowEnd, i] = currentNum++;
        }
        rowEnd--;
        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, columnStart] = currentNum++;
        }
        columnStart++;
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = 4;
int[,] spiralArray = Create2DSpiralArray(num);
Print2DArray(spiralArray);