// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание 
// нового двумерного массива без строки и столбца
// Пример вы найдете в конце презентации к семинару.

int[,] GetArray(int m, int n, int min, int max) 
// Задаем массив
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

int[,] newArray = GetArray(3, 4, 1, 10);
PrintArray(newArray);

// Поиск минимального элемента массива и его индексов
int k = newArray.GetLength(0);
int l = newArray.GetLength(1);
int number = 0;
int numberj = 0;
int minj = newArray[0,0];
int min = newArray[0,0];
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
    if (minj > newArray[i,j])
    {
        minj = newArray[i,j];
        numberj = j;
    }
    }
if (min > minj) 
    {
    min = minj; 
    number = i;
    }
}
Console.Write($"Минимальный элемент {min} в строке {number}, столбце {numberj}");
Console.WriteLine();

// Удаление из исходного массива строки и столбца 
int[,] changarray = new int[newArray.GetLength(0)-1, newArray.GetLength(1)-1];
int s = 0;
for(int i = 0; i < newArray.GetLength(0); i++)
{
if (i != number)
{
int d = 0;
for (int j = 0; j < newArray.GetLength(1); j++)
{
if (j != numberj) changarray[(i-s),(j-d)] = newArray[i,j];
else d++;
}
}
else s++;
}

PrintArray(newArray);
Console.WriteLine($"Удалена строка с индексом {number} и столбец с индексом {numberj}, содержащие минимальный элемент {min}");
Console.WriteLine("Измененный массив:");
PrintArray(changarray);