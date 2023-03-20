// задайте массив вещественных чисел.Найдите разницу
//между минимальными максимальным элементом массива.
//[37 22 2 78]->76
double[]array={3.14,7.22,2,78};

double max=array[0];
double min=array[0];

foreach(double number in array)
{
  if(number>max)
{
max=number;
}
if(number<min)
{
min=number;
}
}
double diff=max-min;
Console.WriteLine("Массив:");
foreach(double number in array)
{
  Console.WriteLine(number+"");
}
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами:"+diff);







   
      
      
      
