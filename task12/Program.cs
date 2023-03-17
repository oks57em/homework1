
//программа , которая принимает на вход число и выдает
// сумму цифр в числе 
//4 5 2->11  8 2->10  9 0 1 2 -> 12
Console.Write("Введите число:");
int number =Convert.ToInt32(Console.ReadLine());

int sum =0;
while( number>0)
{
     int digit = number%10;
     sum += digit;
     number/=10;
}
Console.WriteLine("Сумма цифр числа равна:"+sum);