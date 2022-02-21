//31. Задать массив из 8 элементов и вывести их на экран
// 32.Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 33.Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34.Написать программу замену элементов массива на противоположные
// 35.Определить, присутствует ли в заданном массиве, некоторое число
// 36.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38.Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39.Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40.В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// 31. Задать массив из 8 элементов и вывести их на экран

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(0,10000);
//     }
// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// int[] arr = CreateArray(8);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));

//  32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(0,2);
//     }
// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// int[] arr = CreateArray(8);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(0,10);
//     }
// }
// void FillArray2(int[] array,int minValue, int maxValue)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(minValue,maxValue);
//     }
// }
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }

// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// int Sum(int[] array)
// {
//     int count = array.Length;
//     int sumP = 0;
//     for (int i = 0; i < count; i++) 
//     {
//         if(array[i] > 0)   sumP += array[i]; 
//     }
//     return sumP;
// }
// int[] arr = CreateArray(12);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// int s = Sum(arr);
// System.Console.WriteLine(s);

//34. Написать программу замену элементов массива на противоположные

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(-10000,10000);
//     }
// }
// string PrintArray3(int[] array)
// {
//     string res =String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]*(-1)} ";
//     }
//     return res;
// }
// string PrintArray2(int[] array)
// {

//     string res =String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// int[] arr = CreateArray(8);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// Console.WriteLine(PrintArray3(arr));

// 35. Определить, присутствует ли в заданном массиве, некоторое число

// int[] array = {545, 246, 122, 15, 112, 75, 2456};
// int n = array.Length;
// int find = 15;
// int index = 0;
// while (index < n )
// {
//     if (array[index] == find)
//     {
//     Console.WriteLine($"заданное число присутствует в массиве");
//         break;
//     }
//     else
//        {
//     Console.WriteLine($"заданное число  не присутствует в массиве");

//        }
//     //index = index + 1;
//     index++;
// }

// 36.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void Method(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//              int count = array[i];
//              Console.WriteLine(count);          
//         } 
//     }
// }
// void Method2(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 != 0)
//         {
//              int count = array[i];
//              Console.WriteLine(count);          
//         } 
//     }
// }
// int[] arr = CreateArray(10);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// Method(arr);
// Console.WriteLine();
// Method2(arr);

// 37.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(0,1000);
//     }
// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void Found(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (10 < array[i] & array[i] < 100)
//         {
//             array[i]= array[i];
//             Console.WriteLine(array[i] );

//         }
//     }
// }
// int[] arr = CreateArray(123);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// Console.WriteLine();
// Found(arr);

// 38.Найти сумму чисел одномерного массива стоящих на нечетной позиции

//  int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(0,10000);
//     }
// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// int Sum(int[] array)
// {
//     int count = array.Length;
//     int sumP = 0;
//     for (int i = 0; i < count; i++) 
//     {
//         if(i %2 != 0)   sumP += array[i]; 
//     }
//     return sumP;
// }

// int[] arr = CreateArray(12);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// int s = Sum(arr);
// System.Console.WriteLine(s);

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

//  int[] CreateArray(int count)
// {
//     return new int[count];
// }
// void FillArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i]= new Random().Next(0,100);
//     }
// }
// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void Method(int[] array)
// {
//     int imax = array.Length;
// if (imax %2 == 0)
// {for (int i = 0; i < imax; i++)
// {
//     int composition = array[i] * array[imax-1]; 

// Console.WriteLine(composition);
// imax--;   
// }}
// if (imax % 2 != 0)
// {for (int i = 0; i < imax-1; i++)
// {
//     int composition2 = array[i] * array[imax-1]; 

// Console.WriteLine(composition2);
// imax--;
// }}
// }
// int[] arr = CreateArray(8);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// Method(arr);

// 40.В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] array = {1.25, 1.546, 5.567, 8.951};
// double Method(double[] array)
// {
//     double Maxcount = array[0];
//     double Mincount = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {if (array[i] > Maxcount)   
//     Maxcount = array[i];}
//     for (int i = 0; i < array.Length; i++)
//     {
//     if (Mincount > array[i])
//     Mincount = array[i];}
//     Console.WriteLine(Maxcount);
//     Console.WriteLine(Mincount);


//     return  Maxcount - Mincount;
// }
// double Razn = Method(array);
// Console.WriteLine($"{Razn :f2}");

