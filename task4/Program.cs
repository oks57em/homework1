// написать программу,на вход число(N),на выходе 
//показать все четные от 1 до N
//5 ->2,4
//8 ->2,4,6,8
Console.WriteLine("ввести число:");
int number=Convert.ToInt32(Console.ReadLine());
int i=2;
if (number<2)
Console.WriteLine("число четное:");
else
   while (i<=number)
   {
    Console.WriteLine(i+"/");
    i+=2;
   }

    


    

