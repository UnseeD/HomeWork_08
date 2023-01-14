// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Input number of lines: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Input number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
print(changear(array));


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] changear(int[,] inArray){
    int[,] sum = new int[inArray.GetLength(0), 2];
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            count += inArray[i,j];
        }
        sum[i, 0] = count;
        sum[i, 1] = i + 1;
        count = 0;
    }
    return sum;
}

void print(int[,] ent)
{   int minn = ent[0, 0];
    int answer = ent[0, 1];
    for (int i = 1; i < ent.GetLength(0); i++)
    {
        if (minn > ent[i, 0]) 
        {
            minn = ent[i, 0];
            answer = ent[i, 1];
        }
    }
    Console.WriteLine($"Line with min sum: {answer} ");
}