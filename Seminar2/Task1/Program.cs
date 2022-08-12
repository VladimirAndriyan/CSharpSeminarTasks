// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2)
{
    Console.Write($"Наибольшая цифра числа {number} = " + digit1);
}
else if (digit2 > digit1)
{
    Console.Write($"Наибольшая цифра числа {number} = " + digit2);
}
else
{
    Console.WriteLine("Цифры равны");
}