// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12



int SumNumbers(int number)
{
    if (number == 0) return number;
    return (number % 10 + SumNumbers(number / 10));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberN = GetNumber("Введите число: ");
Console.WriteLine(SumNumbers(numberN));

