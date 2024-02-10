using System;
class Program
{
    static int MaxValue(int[] arr)
    {
        int maxVal = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
            }
        }
        return maxVal;
    }
    static void Main()
    {
        int[] array = { 44,6,3,26,77,19,24,85,42,15,48,28,4,56,21,55,64,29,30,86,17,45,76,78,13,37,80,27,81,8,84,90,67,59,68,12,62,7,50,10,75,82
,49,16,53,88,20,79,9,72,63,87,57,32,31,71,40,23,70,18,22,52,47,36,1,39,51,33,14,60,74,61,38,41,25,73,83,34,65,2,69,43,58,11,54,35,89,5,66,46 };
        Console.WriteLine(MaxValue(array));
    }
}

