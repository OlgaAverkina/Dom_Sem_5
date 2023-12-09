// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

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

// Меняем массив
void ChangedArray(int[,] arr)
{
int k = arr.GetLength(0);
int l = arr.GetLength(1);
int s = 0;
int[,] temp = new int[1,l];
for (int j = 0; j < l; j++)
{
    temp[s,j]= arr[s,j];
    arr[s,j] = arr[(k-1),j];
    for (int i = 1; i < (k-1); i++)
    {
    arr[i,j] = arr[i,j];
    }
    arr[(k-1),j] = temp[s,j];
}
}   

int[,] newArray = GetArray(3, 3, 1, 10);
PrintArray(newArray);
ChangedArray(newArray);
Console.WriteLine();
PrintArray(newArray);