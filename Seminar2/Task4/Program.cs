// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(number);
 if (number1 >= 100 & number1 < 1000)
{
    int res = number1 / 10;
    int res1 = res % 10;
    Console.WriteLine($"Вторая цифра числа {number} = {res1}");
}
 else
{
    Console.WriteLine("Введено некорректное число");
}
