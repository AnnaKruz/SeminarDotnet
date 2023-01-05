//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

//Тут будут методы
string FindQuarter(int x)
{
   string result = "";
   if(x == 1) result = "x > 0 и y > 0";
   if(x == 2) result = "x < 0 и y > 0";
   if(x == 3) result = "x < 0 и y < 0";
   if(x == 4) result = "x > 0 и y < 0";
   return result;
}

int EnterData(string text)
{
Console.WriteLine(text);
int number = int.Parse(Console.ReadLine());
return number;
}

//Запросим четверть
int x = EnterData("Введите номер четверти: ");

//Анализируем данные
string number = FindQuarter(x);

//Вывод информации
Console.WriteLine($"диапазон возможных координат точек в этой четверти {number}");
