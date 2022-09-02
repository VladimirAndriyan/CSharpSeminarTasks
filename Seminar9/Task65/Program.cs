// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

void PrintNumbersMToN(int n, int m)
{
    if(n < m) return;
    PrintNumbersMToN(n - 1, m);
    Console.Write(n + " ");
}
if(numberM < numberN)
{
    PrintNumbersMToN(numberN, numberM);
}
else Console.WriteLine("Число M должно быть меньше N");