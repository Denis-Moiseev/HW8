void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
            }
        }
    }
}

int[,,] Create3DArray(int x, int y, int z, int startValue, int finishValue)
{
    int[,,] array = new int[x, y, z];
    bool[] used = new bool[finishValue];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int num;
                do
                {
                    num = new Random().Next(startValue, finishValue + 1);
                }
                while (used[num]);

                array[i, j, k] = num;
                used[num] = true;
            }
        }
    }
    return array;
}

int[,,] array = Create3DArray(2, 2, 2, 10, 100);
Print3DArray(array);