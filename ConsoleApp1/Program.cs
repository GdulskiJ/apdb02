﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello");
Console.WriteLine(GetAvg([1,2,3,4,5]));
Console.WriteLine(GetMax([1,2,3,4,5]));
    static double GetAvg(int[] arr)
    {git 
        int sum = 0;
        foreach (var num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }

static int GetMax(int[] arr)
{
    int max = 0;
    foreach (var num in arr)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}