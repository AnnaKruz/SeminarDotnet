// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int SummOfNumbers(int number)
{
    int result = 1;
    for(int i = 1; number > 0; i++)
    {
       number = number / 10;
       result = i;       
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
int s = SummOfNumbers(a);
Console.WriteLine($"количество цифр в числе: {s}");