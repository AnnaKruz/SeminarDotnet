//Задача 45: Напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.

int[] Copy(int[] array)
{
    int[] mass = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        mass[i] = array[i];
    }
    return mass;
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end + 1);
    }
    return array;
}


int[] way1 = CreateMassive(12, -9, 9);
Console.WriteLine($"[{string.Join(", ", way1)}]");
int[] way = Copy(way1);
Console.WriteLine($"copy [{string.Join(", ", way)}]");
