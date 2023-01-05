// **Задача 39:** Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
void ReverseMyArray(int[] arr)
{
    for(int i = 0; i < arr.Length/2; i++)
    {
        int num = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = num;
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

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(6, 0, 9);
PrintArray(array);
ReverseMyArray(array);
PrintArray(array);