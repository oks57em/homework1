// написать программу,которая принимает на вход 
// пятизначное число и проверяет,является ли оно
// палиндромом.
Console.WriteLine("введите пятизначное число");
int a=Convert.ToInt32(Console.ReadLine());
int numA=a/10000;//первая 
int numB=(a/1000)%10;//вторая
int numC=(a/10)%10;//четвертая
int numD=a%10;// пятая
if(numA==numD&&numB==numC)
{
   Console.WriteLine("число палиндром");
}
   else
   {
    Console.WriteLine("число не палиндром");
   }
