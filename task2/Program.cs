// написать программу,которая на вход принимает 3 числа
// и выводит максимальное
// 2 3 7 ->7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("ввести первое число:");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести второе число:");
int numberB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести третье число:");
int numberC=Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA<numberB) max=numberB;
if (numberC>max) max=numberC;
Console.WriteLine($"максимальное число:{max}");

    

