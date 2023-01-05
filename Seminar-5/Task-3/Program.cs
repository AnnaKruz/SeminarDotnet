// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void SearchNumberArray(int[] array, int number) 
{ 
    bool answer = false;
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] == number)
        {
            answer = true;
            break;
        } 
    } 
    Console.WriteLine(answer); 
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

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число: ");
int[] array = CreateArray(12, 0, 10);
Console.WriteLine(String.Join (" ", array));
SearchNumberArray(array, a);


