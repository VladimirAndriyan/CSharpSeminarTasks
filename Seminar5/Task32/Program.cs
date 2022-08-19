//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//  отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// 1ый Вариант решения

// Console.WriteLine("Введите количество элементов массива:");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// Random rand = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-100,101);
// }
// Console.WriteLine(string.Join(", ", array));
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     //array[i] = array[i] * -1;
//     //array[i] = - array[i];
// }
// Console.WriteLine(string.Join(", ", array));

// 2ой Вариант решения(оптимизированный)

int[] array = new int[12];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
Console.WriteLine(string.Join(", ", array));
