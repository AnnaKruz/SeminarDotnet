// Задача 69: Напишите программу, 
// которая принимает на вход два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
// А=3, В=5 -> 243

int ProductOfNumbers(int number, int degree)
{
    if (degree == 0) return 1;
    if (degree == 1) return number;
    return (number * ProductOfNumbers(number, degree-1));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
Console.WriteLine(ProductOfNumbers(numberA, numberB));