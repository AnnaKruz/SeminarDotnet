// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int WorkOfNumbers(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++) 
    {
        result = result * i;
    }
    return result;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число: ");
int s = WorkOfNumbers(a);
Console.WriteLine($"Полученное произведение: {s}");
