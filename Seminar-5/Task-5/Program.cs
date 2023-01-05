// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
void SumNumberArray(int[] array)
{
    if (array.Length%2==0)
        {
        for (int i = 0; i < array.Length/2; i++)
        {
            int sumArray = array[i] * array[array.Length - 1 - i];
            Console.Write($"{sumArray}, ");
        }        
        }
    else
        {
        for (int i = 0; i < array.Length/2; i++)
        {
            int sumArray = array[i] * array[array.Length - 1 - i];
            Console.Write($"{sumArray}, ");
        }
        Console.Write($"{array[array.Length/2]}");
        }
}
int[] CreateArray(int count, int begin, int end)
{
    int[] array = new int[count];
    for(int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int[] array = CreateArray(4, 0, 9);
Console.WriteLine(String.Join (" ", array));

SumNumberArray(array);
