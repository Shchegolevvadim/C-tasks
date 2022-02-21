// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

//23. Показать таблицу квадратов чисел от 1 до N 
// int N = new Random().Next(1,10);
// Console.WriteLine(N);
// string Square(int x)
// {
//     string res = string.Empty;
//     for (int i = 1; i <= N; i++)
//     {
//         res += $"{i*i} ";
//     }
//     return res;
// }
// Console.WriteLine(Square(N));

// 24. Найти кубы чисел от 1 до N
// int N = new Random().Next(1,10);
// Console.WriteLine(N);
// string Kube(int x)
// {
//     string res = string.Empty;
//     for (int i = 1; i <= N; i++)
//     {
//         res += $"{i*i*i} ";
//     }
//     return res;
// }
// Console.WriteLine(Kube(N));

// 25. Найти сумму чисел от 1 до А

// int A = new Random().Next(1,10);
// Console.WriteLine(A);
// int sum(int x)
// {
//     int res = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         res += i;
//     }
//     return res;
// }
// Console.WriteLine(sum(A));

// 26. Возведите число А в натуральную степень B используя цикл

// Console.Write("Введите x: ");
//             double x = Convert.ToDouble(Console.ReadLine());
//             double S = 1;
//             Console.Write("Введите степень: ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             for (int i = 0; i < n; i++)
//             {
//                 S *= x;
//             }
//             Console.WriteLine(S);

// 27. Определить количество цифр в числе

// int a = new Random().Next(1,10000000);
// Console.WriteLine(a);
// string b = Convert.ToString(a);
// int result = b.Length;
// Console.WriteLine(result);

// 28. Подсчитать сумму цифр в числе


// int a = int.Parse(Console.ReadLine());
//             int s = 0;
//             while (a > 0)
//             {
 
//                 s = s + a % 10;
//                 a = a /10 ;
 
//             }
// Console.WriteLine(s);

// 29. Написать программу вычисления произведения чисел от 1 до N

// int N = new Random().Next(1,20);
// Console.WriteLine(N);
// int fact(int x)
// {
//     int res = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         res *= i;
//     }
//     return res;
// }
// Console.WriteLine(fact(N));

// 30. Показать кубы чисел, заканчивающихся на четную цифру

// int N = 15;
// Console.WriteLine(N);
// String Cube(int n)
// {
//     string res = String.Empty;
//     for (int i =1; i <= n; i++)
//     {
//         if (i*i*i % 2 == 0)
//         res += $"{i * i * i}  ";
//     }
//     return res;
// }
// Console.WriteLine(Cube(N));