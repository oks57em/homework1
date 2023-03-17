// цикл который принимает на вход 2 числа (AиB)
//возвращает число A в натуральную степень B
//2,4->16
Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

int result =1;
for(int i=0; i<b;i++)
{
    result*=a;
}
Console.WriteLine("{0} в степени {1}равно{2}",a,b,result);
