// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();

int[,,] array = GetArray(2, 2, 2, 1, 100);

PrintArray(array);

int[,,] GetArray(int m, int n, int z, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, z];
    int[] rec = new int[m * n * z];
    int index = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {   
                bool flag = false;
                while (flag == false)
                {
                    int count = new Random().Next(minValue, maxValue + 1);
                    flag = def(rec, count);
                    if (def(rec, count) == true)
                    {
                        rec[index] = count;
                        result[i,j,k] = count;
                        index++;
                    }
                }
                
            }
            
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i,j,k]}({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool def(int[] array, int count)
{
    foreach (int i in array)
    {
        if (i == count) return false;
    }
    return true;
}