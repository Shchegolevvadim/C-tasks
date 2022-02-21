// // 0. Вывести квадрат числа 
// //1. По двум заданным числам проверять является ли первое квадратом второго 
// //2. Даны два числа. Показать большее и меньшее число 
// //3. По заданному номеру дня недели вывести его название
// // 4. Найти максимальное из трех чисел 
// //5. Написать программу вычисления значения функции y=f(a) 
// //6. Выяснить является ли число чётным 
// //7. Показать числа от -N до N 8. Показать четные числа от 1 до N 
// //9. Показать последнюю цифру трёхзначного числа
// //10. Показать вторую цифру трёхзначного числа
// //11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// //12. Удалить вторую цифру трёхзначного числа
// //13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// //14. Найти третью цифру числа или сообщить, что её нет*/
// // 0. Вывести квадрат числа 
// int a = 7;
// int b = a*a;
// Console.WriteLine(b);


// //1. По двум заданным числам проверять является ли первое квадратом второго 
// int x = 5;
// int stepen = 2;
// Math.Pow(x, stepen);
// Console.WriteLine("5^2 = " + Math.Pow(x, stepen));

//  int i = Convert.ToInt32(Math.Sqrt(5.25));
//  Console.WriteLine(i);
 
// int e = 49;
// int f = 7;
// if ((e*e) == f)
// {
//     Console.Write(" f - второе число квадрат первого");
// }
//     if ((f*f) == e)
//     {
//         Console.Write("e - первое число квадрат второго");
//     }

// //2. Даны два числа. Показать большее и меньшее число 


//  int c = 3;
//  int d = 7;
//  if (c > d)
//  {
//      Console.WriteLine(c);
//  }
//  else 
//  {Console.WriteLine(d);
//  };

// //3. По заданному номеру дня недели вывести его название

// Console.Write("Введите число: ");
// int num = Convert.ToInt16(Console.ReadLine());
// switch (num)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("ERROR"); break;
// }
// Console.ReadKey();

// // 4. Найти максимальное из трех чисел 

// int z = 20, q = 26, w = 6;
// int max = z;
// if(z > max) max = z;
// if(q > max) max = q;
// if(w > max) max = w;
// Console.Write("max =");
// Console.WriteLine(max);


// //5. Написать программу вычисления значения функции y=f(a) 
// Console.Clear();
// int Function(int x)
// {
// int y = x + 5;

// return y;
// }

// System.Console.WriteLine(Function(122));





// //6. Выяснить является ли число чётным 
// bool j(int m) => m % 2 == 0;
// Console.Write(j(12));

// //7. Показать числа от -N до N 
// int N = 5;
// int Numbers(int N)
// {
// for (int i = -5; i <= 5 ; i++)

//     {
//     Console.Write(i +" ");
//     }
//     return N;
// }
// Numbers(15);   
// 8. Показать четные числа от 1 до N 
// int N = 10;
// int method(N)
// {for (int i = 1; i <= N; i++ )

   
//     if (i % 2 == 0)
//     {

//     Console.WriteLine(i);
//     }
// }
// method(20);


// // //9. Показать последнюю цифру трёхзначного числа
// void method1(int n)
// {
//  int a = n;
//  string b = Convert.ToString(a);
//  char c = b[2];
//  Console.WriteLine(c);
// }
// method1(258);
// //10. Показать вторую цифру трёхзначного числа

// void method2(int n)
//  {
//   int a = n;
//   string b = Convert.ToString(a);
//   char c = b[1];
//  Console.WriteLine(c);
//  }
//  method2(258);




//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int a = new Random().Next(10,99);
// string b = Convert.ToString(a);
// char c = b[0];
// char d = b[1];
// if (c > d)
// {
//     Console.WriteLine(c);
// }
// if (d > c)
// {
//     Console.WriteLine(d);
// }
// Console.WriteLine(a);
      

 //12. Удалить вторую цифру трёхзначного числа
// int number = new Random().Next(100,999);
// Console.WriteLine(number);
// string Delete_Second_Digit (int n)
// {
//     if (n < 0)
//     n *= -1;
//     return $"{n / 100}{n % 10}";
// }
// Console.WriteLine(Delete_Second_Digit(number));

// //13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// double a = 15;
// double b = new Random().Next(0,10);
// Console.WriteLine(b);
// double result = a / b;
// string d = Convert.ToString(result);
// if (a % b == 0)
// {
//     Console.Write("Число делится");
// }
// if (a % b > 0) 
// {
// Console.WriteLine(d[2]);
// }
 

// //14. Найти третью цифру числа или сообщить, что её нет*/
//  int a = new Random().Next(10,1000);
//  Console.WriteLine(a);
// string b = Convert.ToString(a);
// if (a < 100)
// {
//     Console.WriteLine("Числа нет"); 
// }
// if (a > 100)
// {
//     Console.Write(b[2]);
// }
// else Console.WriteLine ("Числа нет");




