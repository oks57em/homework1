// Сформируйте трехмерный массив из неповторяющихся
// двузначных чисел.Напишите программу,которая будет
// построчно выводить массив,добавляя индексы элемента.
int deep1=InputInt("ввести размерность 1:");
int deep2=InputInt("ввести размерность 2:");
int deep3=InputInt("ввести размерность 3:");
int countNums=89;

if(deep1*deep2*deep3>countNums)
{
   Console.Write("массив слишком большой");
   return;
}
int[,,]resultNums=Create3DMassive(deep1,deep2,deep3);
for(int i=0;i<resultNums.GetLength(0);i++)
{
    for(int j=0;j<resultNums.GetLength(0);j++)
    {
        for(int k=0;k<resultNums.GetLength(0);k++)
        {
          Console.WriteLine($"[{i},{j},{k}] -{resultNums[i,j,k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMassive(int size1,int size2,int size3)
{
   int[,,]array = new int[size1,size2,size3];
   int[]values=new int[countNums];
   int num=10;
    for(int i=0;i<values.GetLength(0);i++)
    values[i]=num++;
    for(int i=0;i<values.GetLength(0);i++)
    {
      int randomInd=new Random().Next(0,values.Length);
      int temp=values[i];
      values[i]=values[randomInd];
      values[randomInd]=temp;
    }
    int valueIndex=0;
    for(int i=0;i<array.GetLength(0);i++ )
    {
       for(int j=0;j<array.GetLength(1);j++)
       {
            for(int k=0;k<array.GetLength(2);k++)
            {
               array[i,j,k]=values[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{ 
   Console.Write(output);
   return int.Parse(Console.ReadLine());
}

          
   
   