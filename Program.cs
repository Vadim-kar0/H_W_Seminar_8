// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// void BubleSort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            for (int k = 0; k < array.GetLength(1) - 1; k++)
//            {
//              if (array[i, k] < array[i, k + 1])
//             {
//                 int memory = array[i, k + 1];
//                 array[i, k + 1] = array[i, k];
//                 array[i, k] = memory;

//             }
//            }
//         }
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// BubleSort(array);
// Console.WriteLine();
// PrintArray(array);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
//  1 строка

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] Array = GetArray(rows, columns, 0, 10);
// PrintArray(Array);
// Console.WriteLine();


// int GetNumberMinimumLineSummary(int[,] array)
// {
//     int summ = 0;
//     int memory = 0;
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ = array[i, j] + summ;
//         }
//         //Console.WriteLine(summ); Просмотр суммы в каждой строке
//         if (i == 0)
//         {
//             memory = summ;
//         }
//         if (summ < memory)
//         {
//             memory = summ;
//             result = i + 1;
//         }
//         summ = 0;
//     }
//     return result;
// }
// Console.WriteLine($"Строка {GetLineSummary(Array)}");


// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] Array1 = GetArray(rows, columns, 0, 10);
// int[,] Array2 = GetArray(rows, columns, 0, 10);

// int[,] GetSquareArray(int[,] array1, int[,] array2)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i,j] = array1[i,j] * array2[i,j];
//         }

//     }
//     return result;
// }

// int[,] Array3 = GetSquareArray(Array1,Array2);

// PrintArray(Array1);
// Console.WriteLine();
// PrintArray(Array2);
// Console.WriteLine();
// PrintArray(Array3);




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int deep = Convert.ToInt32(Console.ReadLine());
if (deep*columns*rows>90)
{
    Console.WriteLine("Массив из неповторяющихся чисел создать не возможно,");
    Console.WriteLine("так как количество создаваемых ячеек превышает количество положительных двузначных чисел");
    Console.WriteLine("Нажмите Control + С");
}
int[,,] array3D = new int[rows, columns, deep];

void FillArray3D(int[,,] array)
{
    int[] memory = new int[90];// массив всех положительных двузначных чисел
    int chislo = 10;
    for (int i = 0; i < memory.Length; i++)
    {
        memory[i] = chislo;
        chislo++;
    }

    int m = deep * rows * columns;
    int[] numbers = new int[m];// массив неповторяющихся двузначных чисел в случайном порядке
    for (int i = 0; i < numbers.Length; i++)
    {
        int j = new Random().Next(0, 90); ;
        while (memory[j] == 0)
        {
            j = new Random().Next(0, 90);
        }
        numbers[i] = memory[j];
        memory[j] = 0;

    }
    int count = 0;
    for (int i = 0; i < rows; i++) // Заполнение трёхмерного массива из массива который содержит неповторяющиеся числа
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                array[i, j, k] = numbers[count];
                count++;

            }
        }
    }
}
void PrintArray3D(int[,,] Array)
{
    for (int k = 0; k < deep; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{Array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
FillArray3D(array3D);
PrintArray3D(array3D);



// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// int N = 4, M = 4;
// int[,] A = new int[N, M];


// Решаем по методу выхода из лабиринта 
// 1. создаём стены из цифр для остановки циклов движения
//(цикл остановится если в следующей клетке будет находится число отличное от нуля)
// 2.Создём цикл условием выхода из которого будет 
// последоваетльное увеличение числа до общего количества ячеек массива

// !!!!!!!!!!!!!Работает только с квадратами

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillSpiral(int[,] Array)

// {
//     int n = Array.GetLength(0);
//     int m = Array.GetLength(1);
//     int count = 1; // переменная для заполнения


//     //Заполняем периметр массива
//     for (int j = 0; j < n; j++)
//     {
//         Array[0, j] = count;
//         count++;
//     }
//     for (int i = 1; i < m; i++)
//     {
//         Array[i, n - 1] = count;
//         count++;
//     }
//     for (int j = n - 2; j >= 0; j--)
//     {
//         Array[m - 1, j] = count;
//         count++;
//     }
//     for (int i = m - 2; i > 0; i--)
//     {
//         Array[i, 0] = count;
//         count++;
//     }
//     //Периметр заполнен.
//     int c = 1;
//     int d = 1;

//     while (count < m * n)
//     {
//         //Движемся вправо.
//         while (Array[c, d + 1] == 0)
//         {
//             Array[c, d] = count;
//             count++;
//             d++;
//         }

//         //Движемся вниз.
//         while (Array[c + 1, d] == 0)
//         {
//             Array[c, d] = count;
//             count++;
//             c++;
//         }

//         //Движемся влево.
//         while (Array[c, d - 1] == 0)
//         {
//             Array[c, d] = count;
//             count++;
//             d--;
//         }

//         //Движемся вверх.
//         while (Array[c - 1, d] == 0)
//         {
//             Array[c, d] = count;
//             count++;
//             c--;
//         }
//     }

//     //Клетка в центре не заполнена ищем её и заполняем
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (Array[i, j] == 0)
//             {
//                 Array[i, j] = count;
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк и столбцов массива: ");
// int rows = int.Parse(Console.ReadLine());
// int columns = rows;
// int[,] Aaaaarray = new int[rows,columns];
// PrintArray(Aaaaarray);
// FillSpiral(Aaaaarray);
// PrintArray(Aaaaarray);