// 48. Показать двумерный массив размером m×n заполненный целыми числами
// 49. Показать двумерный массив размером m×n заполненный вещественными числами
// 50. В двумерном массиве n×k заменить четные элементы на противоположные
// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// 54. В матрице чисел найти сумму элементов главной диагонали
// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// 56. Написать программу, которая обменивает элементы первой строки и последней строки
// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// 60. Составить частотный словарь элементов двумерного массива
// 61. Найти произведение двух матриц
// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
// 65. Спирально заполнить двумерный массив:

//  48.Показать двумерный массив размером m×n заполненный целыми числами

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 100);

//         }
//     }
// }    
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// 49. Показать двумерный массив размером m×n заполненный вещественными числами

// void PrintArray(double[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]}   ");
//          }
//      Console.WriteLine();
//     }
// }

// void FillArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] =  (i * 0.2 + j * 0.3);

//         }
//     }
// }    
// double[,] matrix = new double[3, 4];
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

//  50. В двумерном массиве n×k заменить четные элементы на противоположные

//  void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 100);

//         }
//     }
// }    
// void FillArray2(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i,j] %2 == 0)
//             {
//                 matr[i,j] = matr[i,j] * (-1);
//             }
//             if (matr[i,j] %2 != 0)
//             {
//                 matr[i,j] = matr[i,j];
//             }
            
//         }
//     }
// }    
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// Console.WriteLine();
// FillArray2(matrix);
// PrintArray(matrix);

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = i + j;

//         }
//     }
// }    
// int[,] matrix = new int[3, 4];

// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }
//     }
// }    
// void FillArray2(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if((i % 2 == 0) && (j % 2 == 0))
//              {
//             matr[i,j] = matr[i, j] * matr[i, j] ;
//              }
//         }
//     }
// }    
// void PrintArray2(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr [i, j] ,3} ");
            
//          }
//      Console.WriteLine();
//     }
// }
// int[,] matrix = new int[4, 4];

// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// FillArray2(matrix);
// PrintArray2(matrix);

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }
//     }
// }    
// void PrintArray(int[,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }
// Console.WriteLine("Пользователь вводит число");
// int number = Convert.ToInt32(Console.ReadLine());
// void Method(int[,] matr, int number)

// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             int m = i + 1;
//             int n = j + 1;
//             if(matr[i, j] == number)
//             {
//                 Console.WriteLine($"Число {number} находится в {m} строке, {n} столбце");
//             }
//             else
//             {Console.WriteLine($"Ваше число не найдено");}
//         }
//     }
// }

// int[,] matrix = new int[4, 4];
// FillArray(matrix);

// PrintArray(matrix);
// Console.WriteLine();
// Method(matrix,number);

// 54. В матрице чисел найти сумму элементов главной диагонали

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 25);
//         }
//     }
// }  
// void PrintArray(int[,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }
// void Method(int[,] matr)
// {int sumn = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//         {
//              if(i == j)    sumn += matr[i,j];            
//         }
//     }   
//     Console.WriteLine(sumn);     
// }
// int[,] matrix = new int[3, 3];
// FillArray(matrix);
// PrintArray(matrix);
// Method(matrix);

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


// class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите размер матрицы:");
//             int N = int.Parse(Console.ReadLine());
//             int M = int.Parse(Console.ReadLine());
//             int[,] matrix = new int[N, M];
//             Random rand = new Random();
//             int[] summ = new int[M];
//             for (int i = 0; i < N; i++)
//             {
//                 for (int j = 0; j < M; j++)
//                 {
//                     matrix[i, j] = rand.Next(0, 10); 
//                 }
//             }
//             Console.WriteLine("Матрица");
//             for (int i = 0; i < N; i++)
//             {
//                 for (int j = 0; j < M; j++)
//                 {
//                     Console.Write(matrix[i, j]); 
//                     summ[i] += matrix[j, i];      
//                 } 
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
//             foreach (double elem in summ)
//             {
//                 Console.WriteLine(elem/M); 
//             }
//         }
//     }

// 56. Написать программу, которая обменивает элементы первой строки и последней строки

//  void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }
//     }
// }  
// void PrintArray(int[,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }
// void Method(int[,] matr)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//             int temp = matr [0, j];
//                 matr [0, j] = matr [matr.GetLength(0) - 1, j];
//                 matr [matr.GetLength(0) - 1, j] = temp;   
//          }
//     }
// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Method(matrix);
// PrintArray(matrix);

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.
// using System;
// using System.Linq;
 
// namespace n
// {
 
//     internal class Program
//     {
//         private static void Main(string[] args)
//         {
 
//             var matrix = new int[3, 3];
//             var rnd = new Random();
 
//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix.GetLength(1); j++)
//                 {
//                     matrix[i, j] = rnd.Next(0, 36);
//                     Console.Write(matrix[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
 
//             var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
 
//             int c = 0;
//             for (int j = 0; j < matrix.GetLength(0); j++)
//             {
//                 for (int k = 0; k < matrix.GetLength(1); k++)
//                 {
//                     matrix[j, k] = arr[c];
//                     Console.Write(matrix[j, k] + "  ");
//                     c++;
//                 }
//                 Console.WriteLine();
//             }
            
//         }
//     }
// }

// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы, либо сообщить что элемента нет

//  void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }
//     }
// }  
// void PrintArray(int[,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }
// void Method(int[,] matr)
// {
//     for(int i=0; i < matr.GetLength(0)-1; i++) {
//      for(int j=i+1; j < matr.GetLength(1); j++) {
//           int temp = matr[i,j];
//           matr[i,j] = matr[j,i];
//           matr[j,i] = temp;
//      }
// }
// }
// int[,] matrix = new int[5, 5];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Method(matrix);
// PrintArray(matrix);

//59.  В прямоугольной матрице найти строку с наименьшей суммой элементов.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
 
// namespace ConsoleApplication2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[][] a;
//             Console.WriteLine("Введите строки:");
//             int n = int.Parse(Console.ReadLine());
//             Console.WriteLine("Введите столбцы:");
//             int m = int.Parse(Console.ReadLine());
//             a = new int[n][];
//             int[] sum = new int[n];
//             for (int i = 0; i < n; i++)
//             {
//                 a[i] = new int[n];
//                 for (int j = 0; j < m; j++)
//                 {
//                     Console.Write("Введите а[{0}][{1}] = ", i, j);
//                     a[i][j] = int.Parse(Console.ReadLine());
//                     sum[i] += a[i][j];
//                 }
 
//             }
//             int max = Array.IndexOf(sum,sum.Max());
//             int min = Array.IndexOf(sum, sum.Min());
 
          
 
//             Console.Write("Минимальная сумма элементов массива по строкам {0} \n Массив:", min);
//             for (int j = 0; j < m; j++)
//             {
//                 Console.Write(" {0} ", a[min][j]);
//             }
//                 Console.ReadLine();
//         }
//     }
// }

// 60. Составить частотный словарь элементов двумерного массива

//  void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }
//     }
// }  
// void PrintArray(int[,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }


//  int[,] matrix = new int[5, 5];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();

// 61. Найти произведение двух матриц

//     static void Main(string[] args)
//     {
//         var A = InitializationMatrix();
//         Thread.Sleep(100);
//         var B = InitializationMatrix();            
//         var C = MultiplicationMatrix(A, B);

//         Console.ReadLine();
//     }
// Main(args);
//     static int[,] InitializationMatrix()
//     {
//         var matrix = new int[3, 3];

//         var rand = new Random();

//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 matrix[i, j] = rand.Next(1, 15);
//                 Console.Write(matrix[i, j] + ", ");
//             }
//             Console.WriteLine();
//         }

//         return matrix;
//     }
  
//      static int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
//     {
//         var resultMatrix = new int[3, 3];

//         for (int i = 0; i < firstMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < secondMatrix.GetLength(1); j++)
//             {
//                 for (int k = 0; k < secondMatrix.GetLength(0); k++)
//                 {
//                     resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
//                 }
//                 Console.Write(resultMatrix[i, j] + ", ");
//             }
//             Console.WriteLine();
//         }

//         return resultMatrix;
//     }

// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

//  void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }
//     }
// }  
// void PrintArray(int[,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]} ");
//          }
//      Console.WriteLine();
//     }
// }
// void Method (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {int mincount = matr[i,j];
//          if (matr[i,j] < mincount)
//          {mincount = matr[i,j];}
//          if (matr[i,j] != mincount)
//             {Console.Write($"{matr[i, j]} ");}
//          }
//      Console.WriteLine();
//          }
          
//     }      

// int[,] matrix = new int[3, 3];
// FillArray(matrix);
// PrintArray(matrix);
// Method(matrix);



// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
// int row = 9;
// int[,] triangle = new int[row, row];
// const int cellWidth = 3;

// void Filltriangle()
// { 
//     for (int i = 0; i < row; i++)
//     {
//         triangle[i, 0] = 1;
//         triangle[i, i] = 1;
//     }

// for (int i = 2; i < row; i++)
// {
//     for (int j = 1; j <= i; j++)
//     {
//         triangle [i, j] = triangle[i -1, j -1] + triangle[i -1, j];
//     }
// }
// }

// void PrintTriangle()
// {
//     for (int i = 0; i < row;i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//         if (triangle[i, j] != 0)
//         Console.Write($"{triangle[i, j],cellWidth}");
//         }
//         Console.WriteLine();
//     }
        
    
// }
// void Magic()
// {
//     int col = cellWidth * row;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j <= i; j++)
//     {
    
//             Console.SetCursorPosition(col, i + 1);
//             if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
//         // if (triangle[i, j] != 0) Console.WriteLine("*");
//             col += cellWidth * 2;
//     }
//     col = cellWidth * row - cellWidth * (i + 1);
// }}
// Console.ReadLine();
// Filltriangle();
// PrintTriangle();
// Console.ReadLine();
// Magic();

