// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] ReversArrayTwo(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int temp;
        int tempindex = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = tempindex; j < array.GetLength(1); j++)
            {
                temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
            tempindex++;
        }
    }
    else Console.WriteLine("Массив нельзя перевернуть");
        return array;
}

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
            array[i, j] = new Random().Next(begin, end + 1);
        }
    }
    return array;
}

int[,] matrix = FillArray(4, 4, 0, 10);
// Выводим массив
PrintArrayTwo(matrix);
Console.WriteLine();
int[,] arrayRevers = ReversArrayTwo(matrix);
if (arrayRevers.GetLength(0) == arrayRevers.GetLength(1))
{
    PrintArrayTwo(arrayRevers);
}
//PrintArrayTwo(arrayRevers);