// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Table(int n) {
    int i = 1;
    while (i <= n){
        Console.Write(i * i + ", ");
        i++;
    }
}

int EnterData(string text)
{
Console.WriteLine(text);
int number = int.Parse(Console.ReadLine());
return number;
}

int number = EnterData("Введите число ");
Table(number);