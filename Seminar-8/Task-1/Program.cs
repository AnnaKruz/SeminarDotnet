// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void ReversArrayTwo (int[,] array)
{
    int temp =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp=array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1, i] = temp;
    }
    
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


int[,] matrix = FillArray(4, 4, 0, 10);
// Выводим массив
PrintArrayTwo(matrix);
ReversArrayTwo(matrix);
Console.WriteLine();
PrintArrayTwo(matrix);