// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Задаем массив
int[,] GetArray(int m, int n, int min, int max) 
{
int[,] array = new int[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
array[i, j] = rand.Next(min, max);
}
}
return array;
}
// Печатаем массив
void PrintArray(int[,] arr)                       
{        
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write($"{arr[i, j]} ");
}
Console.WriteLine();
}
}
// Находим искомую строку
void MinSum(int[,] arr)
{
int k = arr.GetLength(0);
int l = arr.GetLength(1);
int sum = 0;
int number = 0;
int min = 0;
for (int z = 0; z < l; z++)
{min = arr[0,z] + min;}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
    sum = arr[i,j] + sum;
    }
    if (min > sum) 
    {
    min = sum; 
    number = i;
    }
    sum = 0;
}
Console.Write($"Минимальная сумма {min} в строке {number}");
}
int[,] newArray = GetArray(3, 4, 1, 10);
PrintArray(newArray);
MinSum(newArray);