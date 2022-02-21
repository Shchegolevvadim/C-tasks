// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D


// // 15. Дано число. Проверить кратно ли оно 7 и 23
// int a = 161;
// Console.WriteLine(a);
// if ((a % 7 == 0) && (a % 23 == 0))
// {
//     Console.Write("Число делится на 7 и 23");
// }

 //16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// Console.Write("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
// switch (num)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота - выходной день"); break;
//     case 7: Console.WriteLine("Воскресенье - выходной день"); break;
//     default: Console.WriteLine("ERROR"); break;
// }
// Console.ReadKey();


//17. По двум заданным числам проверять является ли одно квадратом другого

// int a = 6;
// int b = 46;
// void method2 (int a, int b)
// {

// if (b*b == a)
// {
//     Console.WriteLine("Первое число квадрат второго");
    
// }

// else if (a*a == b)
// {
//     Console.WriteLine("Второе число квадрат первого");
    
// }

// else
// { 
//     Console.WriteLine("Не является");
// }
// }
// method2(a,b);

//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


// bool method(bool x, bool y)
// {
// return !(x | y) == (!x & !y);

// }
// Console.WriteLine(method(true,false));

// Console.WriteLine(method(true,true));

// Console.WriteLine(method(false,false));

// Console.WriteLine(method(false,true));

//19.  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int x = new Random().Next(-100,100);
// int y = new Random().Next(-100,100);
// Console.WriteLine($"{x}  {y}");

// void Method (int x,int y)
// {
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("точка в 1 четверти");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("точка в 2 четверти");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка в 3 четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Точка в 4 четверти");
// }
// }
// Method(x,y);

// 20. Задать номер четверти, показать диапазоны для возможных координат

// Console.Write("Введите номер четверти   ");
// int a = int.Parse(Console.ReadLine());
// void method(int a)
// {
// if (a == 1)
// {
//     Console.WriteLine("Диапазон от 0 до + бесконечности по y и x");
// }
// else if (a == 2)
// {
//     Console.WriteLine("Диапазон от 0 до + бесконечности по y и x от 0 и до минус бесконечности");
// }
// else if (a == 3)
// {
//     Console.WriteLine("Диапазон от 0 до - бесконечности по y и x от 0 и до минус бесконечности");
// }
// else if (a == 4)
// {
//     Console.WriteLine("Диапазон от 0 до - бесконечности по y и x от 0 и до плюс бесконечности");
// }
// }
// method(a);


// 21. Программа проверяет пятизначное число на палиндромом.
// int number = 12321;
// int Palindr(int x)
// {
//     if((number/10000 == number%10) && (number / 1000 % 10 == number / 10 % 10))
//         return 1;
//     return -1;
// }
// Console.WriteLine(Palindr(number));
// Console.WriteLine($"1 - является");
// Console.WriteLine($"-1  - не является");

// 22.Найти расстояние между точками в пространстве 2D
// int x1 = 6;
// int y1 = 2;
// int x2 = 4;
// int y2 = 1;

// double Distance(int a1, int a2, int b1, int b2)
// {
//    double katet1 = a1 - a2;
//    double katet2 = b1 - b2;
//    double gipoten = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
//    return (gipoten);

// }
// Console.WriteLine(Distance(x1, x2, y1, y2));

//  Найти расстояние между точками в пространстве 3D

// int x1 = 8;
// int y1 = 2;
// int z1 = 3;
// int x2 = 4;
// int y2 = 1;
// int z2 = 5;

// double Distance(int a1, int a2, int b1, int b2,int c1, int c2)
// {
//    double katet1 = a1 - a2;
//    double katet2 = b1 - b2;
//    double katet3 = c1 - c2;
//    double gipoten = Math.Sqrt(katet1 * katet1 + katet2 * katet2 + katet3 * katet3);
//    return (gipoten);

// }
// Console.WriteLine(Distance(x1, x2, y1, y2,z1, z2));
