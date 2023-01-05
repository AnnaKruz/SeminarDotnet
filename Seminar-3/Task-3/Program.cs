
double FindDistance(int x1, int y1, int x2, int y2) {
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}


int EnterData(string text)
{
Console.WriteLine(text);
int number = int.Parse(Console.ReadLine());
return number;
}

int x1 = EnterData("Введите координаты X1: ");
int y1 = EnterData("Введите координаты Y1: ");
int x2 = EnterData("Введите координаты X2: ");
int y2 = EnterData("Введите координаты Y2: ");

double result = FindDistance(x1, y1, x2, y2);

Console.WriteLine($"Расстояние между точками равно {result}");


