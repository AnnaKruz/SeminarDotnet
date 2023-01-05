// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
void PrintArrayTwo(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] FillArray(int rows, int colums, int begin, int end)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(begin, end+1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// запрос количества строк
int rows = EnterData("Введите кочество строк: ");
// запрос количества столбцов
int colums = EnterData("Введите кочество столюцов: ");
// Создаем двухмерный массив и заполняем его случайными числами
int[,] matrix = FillArray(rows, colums, -10, 100);
// Выводим массив
PrintArrayTwo(matrix);