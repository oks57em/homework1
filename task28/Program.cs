// Задайте значение M и N .Напишите программу,которая найдет
// сумму натуральных элементов в промежутке от M до N.
Console.Write("введите значение M:");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение N:");
int n= Convert.ToInt32(Console.ReadLine());
int sum(int m,int n)
{
  if(m==n)
  return n;
    else return m+ sum (m+1,n);
  }
Console.Write($"сумма натуральных элементов в промежутке от M до N {sum(m,n)}");
