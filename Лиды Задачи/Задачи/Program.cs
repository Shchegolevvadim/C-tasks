//41. Выяснить являются ли три числа сторонами треугольника
// 42.Определить сколько чисел больше 0 введено с клавиатуры
// 43.Написать программу преобразования десятичного числа в двоичное
// 44.Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// 45.Показать числа Фибоначчи
// 46.Написать программу масштабирования фигуры
// 47.Написать программу копирования массива

//41. Выяснить являются ли три числа сторонами треугольника
// если сумма двух любых больше третьей то это треугольник
// bool method(int a, int b, int c)
// {
//     return (a + b) > c && (b + c) > a && (a + c) > b;
// }
// Console.WriteLine(method(3,3,2));

//42. Определить сколько чисел больше 0 введено с клавиатуры

// static void Main(string[] args)
//        {
//            int countzero = 0;
//            int countplus = 0;
//            int countminus = 0;
//            int N;
//            Console.Write("Укажите сколько чисел ввести: ");
//            N = Convert.ToInt32(Console.ReadLine());
//            int[] mas = new int[N];
//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine("Введите {0}-й элемент", i + 1);
//                mas[i] = int.Parse(Console.ReadLine());
//            }
//            for (int i = 0; i < N; i++)
//            {
//                if (mas[i] == 0)
//                {
//                    countzero++;
//                }
//                else if(mas[i] < 0)
//                {
//                    countminus++;
//                }
//                else if(mas[i] > 0)
//                {
//                    countplus++;
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("Количество положительных элементов = " + countplus);
//            Console.WriteLine("Количество отрицательных элементов = " + countminus);
//            Console.WriteLine("Количество нулевых элементов = " + countzero);
//            Console.ReadKey();
//        }
// Main(args);
   
//  43.Написать программу преобразования десятичного числа в двоичное

// using System;
// using System.Text;
// class Program
// {
//     static string DecimalToBinary(uint decimalNumber)
//     {
//         var binaryNumber = string.Empty;
//         while (decimalNumber > 0)
//         {
//             binaryNumber = (decimalNumber % 2) + binaryNumber;
//             decimalNumber /= 2;
//         }

//         return binaryNumber;
//     }
    
//     private static void Main(string[] args)
//     {
//         Console.OutputEncoding = Encoding.UTF8;
//         Console.Write("Введите число в десятичной системе: ");
//         var decNum = uint.Parse(Console.ReadLine());
//         var binNum = DecimalToBinary(decNum);
//         Console.WriteLine("{0} => {1}", decNum, binNum);
//         Console.ReadLine();
//     }
// }

// 44.Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// int b1 = 5;
// int b2 = 6;
// int k1 = 2;
// int k2 = 3;
// int x = new Random().Next(0,10);
// Console.WriteLine(x);
// void Method1(int y)
// {
//   y = k1 * x + b1;
//   Console.WriteLine(y); Console.WriteLine($"- координата по y");
// }
// void Method2(int y)
// {
//     y = k2 * x + b2;

//     Console.WriteLine(y);Console.WriteLine($" - координата по x");
// }
// Method1(x);
// Console.WriteLine(0);
// Method2(x);

// 45.Показать числа Фибоначчи

// Console.WriteLine("До какого числа считать ряд Фибоначчи?");
// int number = Convert.ToInt32(Console.ReadLine());

// int perv = 1;

// int vtor = 1;

// int sum = 0;

// Console.Write("{0} ", perv);

// Console.Write("{0} ", vtor);
// while (number >= sum)
// {
//                 sum = perv + vtor;
                
//                     Console.Write("{0} ", sum);
                    
//                         perv = vtor;
//                         vtor = sum;                
// }

// 47.Написать программу копирования массива

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
// void Method(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i];
//         }
// }
// string PrintArray3(int[] array)
// {
//     int count = array.Length;
//     string res =String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// int[] arr = CreateArray(6);
// FillArray(arr);
// Console.WriteLine(PrintArray2(arr));
// Console.WriteLine();
// Console.WriteLine(PrintArray3(arr));

