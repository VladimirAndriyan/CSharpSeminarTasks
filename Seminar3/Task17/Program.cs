// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координаты точки X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y:");
int Y = Convert.ToInt32(Console.ReadLine());
if(X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой плоскости");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй плоскости");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей плоскости");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится в четвертой плоскости");
}
else
{
    Console.WriteLine("Нет такой плоскости");
}