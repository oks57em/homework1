// Задайте одномерный массив, заполненный случайными
// числами.Найдите сумму элементов,стоящих на нечетных
// позициях.
// [3,7,23,12]->19 [-4,-6,89,6]->0
int[]array=new int[10];
Random random =new Random();
for (int i=0; i< array.Length;i++)
{
     array [i]=random.Next(1,101);
}
int sum =0;
for(int i=1;i<array.Length;i+=2)
{
    sum += array[i];
}
Console.WriteLine("Rondom array:");
{
Console.WriteLine();
Console.WriteLine("сумма чисел нечетных позиций:"+sum);
 }














 
