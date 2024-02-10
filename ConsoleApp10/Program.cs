void ArraysSum()
{
    {
        int[,] arr = { { 6, 8, 4 }, { 7, 6, 7 }, { 1, 5, 4 } };
        int sum = SumArray(arr);
        Console.WriteLine($"\nСумма всех чисел матрицы: {sum} ");
    }
    int SumArray(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }
}
ArraysSum();