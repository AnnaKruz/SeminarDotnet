// Принять число
// Написать метод где в цикле находим сумму чисел
// Вывод результата

int SummOfNumbers(int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++) 
    {
        sum = sum + i;
    }
    return sum;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число: ");
int s = SummOfNumbers(a);
Console.WriteLine($"Полученная сумма: {s}");
