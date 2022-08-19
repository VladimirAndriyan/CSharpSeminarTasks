// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите количество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int[] newarray = new int[(array.Length + 1)/2];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.Write(string.Join(", ", array));

for(int i = 0; i < newarray.Length; i++)
{
    newarray[i] = array[i] * array[N - 1 - i];
}
if(array.Length % 2 != 0)
{
    newarray[newarray.Length - 1] = array[array.Length / 2];
}
Console.Write("  ->  ");
Console.WriteLine(string.Join(", ", newarray));

