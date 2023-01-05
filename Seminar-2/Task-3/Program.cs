// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0) {
    Console.WriteLine($"Число {number2}, является кратным числу {number1}");
}
else {
    Console.WriteLine($"Число {number2}, является не кратным {number1}, остаток от деления будет {number1%10}");
}
