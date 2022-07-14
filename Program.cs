// 66. Показать натуральные числа от 1 до N, N задано
// 67. Показать натуральные числа от N до 1, N задано
// 68. Показать натуральные числа от M до N, N и M заданы
// 69. Найти сумму элементов от M до N, N и M заданы
// 70. Найти сумму цифр числа
// 71. Написать программу вычисления функции Аккермана
// 72. Написать программу возведения числа А в целую стень B
// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

// 66. Показать натуральные числа от 1 до N, N задано

// string NumbersFor(int a, int n)
// {    a = 1;
//     string result = String.Empty;
//     for (int i = a; i <= n; i++)
//     {
//         result +=$"{i}  ";
//     }
//     return result;
// }


// Console.WriteLine(NumbersFor(1, 23));


// 67. Показать натуральные числа от N до 1, N задано

// string NumbersRec(int a, int b)
// {
//    if (a >= b) return $"{a}  " + NumbersRec(a - 1, b);
//    else return String.Empty;
    
// }
// Console.WriteLine(NumbersRec(27, 15));

// 68. Показать натуральные числа от M до N, N и M заданы

// string NumbersFor(int a, int n)
// {    a = 16;
//     string result = String.Empty;
//     for (int i = a; i <= n; i++)
//     {
//         result +=$"{i}  ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(16, 23));

// 70. Найти сумму цифр числа

// int CountNumbers(int a)
// {
//   a = Math.Abs(a);
//     if (a > 9)return a % 10 + CountNumbers(a / 10); 
//     return a % 10;    
// }
// Console.WriteLine(CountNumbers(23455));

// 71. Написать программу вычисления функции Аккермана

// Console.Write("Введите число n: ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите число m: ");
//             int m = Convert.ToInt32(Console.ReadLine());
//             A(n, m);
            
//             static int A(int n, int m)
//             {
//                 if (n == 0) return m + 1;
//                 if (n != 0 && m == 0) return A(n - 1, 1);
//                 if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
//                 return A(n,m);
//             }
//             Console.WriteLine(A(n,m));

// 72. Написать программу возведения числа А в целую стень B

//  int PowerFor(int a,int n)
// {int result = 1;
// for (int i = 1; i <= n; i++) result *= a;
// return result;
// }
// Console.WriteLine(PowerFor(3,3));
            
