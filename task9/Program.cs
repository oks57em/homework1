// написать программу,которая принимает на вход координаты
//2-х точек и находит расстояние между ними в 3D пространстве
//A(3,6,8); B(2,1,-7)->15.84
//A(7,-5,0); B(1,-1,9)->11.53
// корень квадратный(x2-x1,2)+(y1-y2,2)+(z1-z2,2)
Double x1,x2,x3,y1,y2,y3,z1,z2,z3,distance;
Console.WriteLine("ввести координаты точки a:");

Console.Write("ввести координаты x1:");
x1=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты x2:");
x2=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты x3:");
x3=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты y1:");
y1=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты y2:");
y2=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты y3:");
y3=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты z1:");
z1=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты z2:");
z2=Convert.ToDouble(Console.ReadLine());

Console.Write("ввести координаты z3:");
z3=Convert.ToDouble(Console.ReadLine());

distance=Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Console.WriteLine("расстояние между точками равно:"+Math.Round(distance,2));