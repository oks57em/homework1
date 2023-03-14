// напишите программу,которая выводит третью цифру
// заданного числа или сообщает,что третьей цифры нет
//645->5 78->третьей нет 
Console.WriteLine("введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number>1000)
{
  while (number>999)
  {
    number/=10;
  }
    Console.WriteLine(number%10);
   } else{
    Console.WriteLine(number%10);
    }
        
    

    

