// Задать массив заполненный случайными,положительными,
// трехзначными числами,написать программу,которая покажет
// количество четных чисел в массиве.
// [345,897,568,234]->2
int[]array=new int[4];
Random random=new Random();
for(int i=0;i< array.Length;i++)
{
   array[i]=random.Next(100,1000);
   
}
int count=0;
foreach(int number in array)
{
if (number%2==0)
{
    count++;
    }
 }
 Console.WriteLine("Random array:");
 foreach(int number in array) 
 {
 Console.WriteLine(number+"");
 } 
Console.WriteLine("Количество четных чисел:"+count);
   
    
   