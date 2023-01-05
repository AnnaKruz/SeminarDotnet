// Задача 65: Задайте значение M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1 N = 5 -> 1, 2, 3, 4, 5
string EnterNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + EnterNumbers(start + 1, end));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberM = GetNumber("Введите число N: ");
int numberN = GetNumber("Введите число M: ");
Console.WriteLine(EnterNumbers(numberM, numberN));