// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// double minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимально значение массива: ");
// double maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m,n];

// Console.WriteLine("____________");
// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = Math.Round((minValue +(new Random().NextDouble())*(maxValue-minValue)),1);
//         Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс стоки искомого элемента: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца искомого элемента: ");
int b = Convert.ToInt32(Console.ReadLine());

int [,] array =new  int [rows,columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i,j] = new Random().Next(0,10);
       Console.Write(array[i,j]+  " ");
    }
    Console.WriteLine();
}
Console.WriteLine("___________________");
Console.WriteLine();

if (a < rows && b < columns) 
{
    Console.Write(array[a,b]);
}
else
{
    Console.Write("такого элемента нет");
}