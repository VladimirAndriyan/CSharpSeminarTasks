// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] array = {1,2,5,7,8};
int[] newarray = new int[array.Length];
for(int i = 0; i < array.Length; i++)
{
   newarray[i] = array[i];
}
array[4] = 10;
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", newarray));