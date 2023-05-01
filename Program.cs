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

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс стоки искомого элемента: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс столбца искомого элемента: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int [,] array =new  int [rows,columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//        Console.Write(array[i,j]+  " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("___________________");
// Console.WriteLine();

// if (a < rows && b < columns) 
// {
//     Console.Write(array[a,b]);
// }
// else
// {
//     Console.Write("такого элемента нет");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] array = new int[,]
// {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 }
// };

// double[] sum = new  double[array.GetLength(1)];
// double[] average = new double[array.GetLength(1)];
   
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            sum[j] = sum[j] + array[i,j];
//            average[j] = Math.Round((sum[j] / (array.GetLength(0))),1);
//         }
//     }
// Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", average)}");

//Второй вариант
// int[,] array = new int[,]
// {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 }
// };
   
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//         sum = sum + array[j,i];
//         }
//         double average = Math.Round((sum/(array.GetLength(0))),1);
//         Console.WriteLine(average);
//     }

//Третий вариант

// int[,] array = new int[,]
// {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 }
// };
// double sum0 = 0;
// double sum1 = 0;
// double sum2 = 0;
// double sum3 = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//             if (j == 0) sum0 = sum0 + array[i,j];
//             if (j == 1) sum1 = sum1 + array[i,j];
//             if (j == 2) sum2 = sum2 + array[i,j];
//             if (j == 3) sum3 = sum3 + array[i,j];
//     }
// }
// double average0 = Math.Round((sum0/(array.GetLength(0))),1);
// double average1 = Math.Round((sum1/(array.GetLength(0))),1);
// double average2 = Math.Round((sum2/(array.GetLength(0))),1);
// double average3 = Math.Round((sum3/(array.GetLength(0))),1);

// Console.WriteLine(average0);
// Console.WriteLine(average1);
// Console.WriteLine(average2);
// Console.WriteLine(average3);

//Четвертый вариант
// int [,] array = {{1,4,7,2},
//                  {5,9,2,3},
//                  {8,4,2,4}};
// int i = 0, j = 0;
// double sum0 = 0, sum1 = 0, sum2 = 0, sum3 = 0;
// for (int k = 0; k < array.GetLength(0); k++)
// {
//         if (j == 0) 
//         {
//             sum0 += array[i,j];
//             j++;
//         }
//         if (j == 1) 
//         {
//             sum1 += array[i,j];
//             j++;
//         }
//         if (j == 2) 
//         {
//             sum2 += array[i,j];
//             j++;
//         }
//         if (j == 3) 
//         {
//             sum3 += array[i,j];
//             j = 0;
//             i++;
//         }
// }
// Console.WriteLine(sum0/array.GetLength(0));
// Console.WriteLine(sum1/array.GetLength(0));
// Console.WriteLine(sum2/array.GetLength(0));
// Console.WriteLine(sum3/array.GetLength(0));

//Пятый вариант
int [,] array =  {{1,4,7,2},
                  {5,9,2,3},
                  {8,4,2,4}};
int i = 0, j = 0;
double sum0 = 0, sum1 = 0, sum2 = 0, sum3 = 0;
for (int k = 0; k < array.GetLength(0)*array.GetLength(1); k++)
{
        switch (j)
        {
            case 0:
            {
                sum0 += array[i,j];
                j++;
                break;
            }
            case 1:
            {
                sum1 += array[i,j];
                j++;
                break;
            }
            case 2:
            {
                sum2 += array[i,j];
                j++;
                break;
            }
            case 3:
            {
                sum3 += array[i,j];
                j = 0;
                i++;
                break;
            }
        }    
}
Console.WriteLine(sum0/array.GetLength(0));
Console.WriteLine(sum1/array.GetLength(0));
Console.WriteLine(sum2/array.GetLength(0));
Console.WriteLine(sum3/array.GetLength(0));