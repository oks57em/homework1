// написать программу,которая принимает на вход цифру,
// обозначающую день недели и проверяет, является ли
// этот день выходным.
Console.WriteLine("введите номер дня недели(от 1 до 7):");
int day =Convert.ToInt32(Console.ReadLine());
if (day>0&&day<6)
Console.WriteLine("рабочий день.");
else if(day>5&&day<8)
Console.WriteLine("выходной.");
else
Console.WriteLine("нет такого дня.");

    



