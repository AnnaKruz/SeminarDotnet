// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// <aside>
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.
// </aside>


void Triangle(int a, int b, int c)
{
    if((a+b) > c && (b+c) >a && (a+c)>b)
    {
        Console.WriteLine("Теугольник существует");
    }
    else
    {
    Console.WriteLine("Теугольник не существует");
    }
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число 1: ");
int b = GetNumber("Введите число 2: ");
int c = GetNumber("Введите число 3: ");
Triangle (a, b, c);
//Console.WriteLine($"существовать треугольник с сторонами такой длины")