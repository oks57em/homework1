// написать программу,на вход число и выдает четное или нет
//4 ->да
//3 ->нет
//7 ->нет
Console.WriteLine("ввести число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number==0)
Console.WriteLine("введено 0,введите правильное число");
else if(number%2==0)
Console.WriteLine("число четное:");
else
Console.WriteLine("число нечетное:");

    

