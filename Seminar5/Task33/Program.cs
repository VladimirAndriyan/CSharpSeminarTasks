// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите количество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска его в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rand = new Random();
bool flag = false;
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9,10);
    if(array[i] == number)
    {
        flag = true;
    }
}
Console.WriteLine(string.Join(", ", array));

if(flag == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}