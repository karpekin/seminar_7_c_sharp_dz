// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
double minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение массива: ");
double maxValue = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];

Console.WriteLine("____________");
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Math.Round((minValue +(new Random().NextDouble())*(maxValue-minValue)),1);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}