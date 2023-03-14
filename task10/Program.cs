// написать программу,которая принимает на вход число(N)
// и выдает таблицу кубов от1 до N
// 3->1,8,27  5->1,8,27,64,125

Console.WriteLine("ввести число:");
int a=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=a; i++)
{
    Console.Write(i*i*i+"\t");
}    
