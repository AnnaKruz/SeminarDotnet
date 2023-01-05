// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5

int Number (int number)
{
    if (number == 1) return number;
    else
    Console.Write($"{Number(number -1)}, ");
    return number;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberN = GetNumber("Введите число: ");
Number(numberN);
Console.Write($"{numberN}");