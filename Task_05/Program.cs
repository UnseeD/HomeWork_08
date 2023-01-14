// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] array = GetArray(4, 4);

PrintArray(array);

int[,] GetArray(int m, int n)
{
    int count = 1;
    int[,] result = new int[m, n];
    for (int i = 0; i < n; i++)
    {
        result[0, i] = count;
        count++;
    }
    for (int j = 1; j < m; j++)
    {
        result[j, n - 1] = count;
        count++;
    }
    for (int i = n - 2; i >= 0; i--)
    {
        result[m - 1, i] = count;
        count++;
    }
    for (int j = m - 2; j > 0; j--)
    {
        result[j, 0] = count;
        count++;
    }

    int a = 1;
    int b = 1;
    while (count < m * n)
    {
        while (result[a, b + 1] == 0)
        {
            result[a,b] = count;
            count++;
            b++;
        }
        while (result[a + 1, b] == 0)
        {
            result[a,b] = count;
            count++;
            a++;
        }
        while (result[a, b - 1] == 0)
        {
            result[a,b] = count;
            count++;
            b--;
        }
        while (result[a - 1, b] == 0)
        {
            result[a,b] = count;
            count++;
            b--;
        }
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (result[i,j] == 0) result[i,j] = count;
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}   ");
        }
        Console.WriteLine();
    }
}