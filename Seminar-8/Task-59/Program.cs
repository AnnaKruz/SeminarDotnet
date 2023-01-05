// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int[] FindMin(int[,] array)
{
    int min = array[0, 0];
    int minCol = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minCol = i;
                minRow = j;
            }
        }
    }
    int[] outdata = new int[2] { minCol, minRow };
    return outdata;
}



int[,] DeleteRowsAndColunsArrayTwo(int[,] array, int[] coordinate)
{
    int[,] newarray = new int[array.GetLength(0) - 1, array.GetLength(1) -1];
    int i, j;
    int index = 0;
    int jndex = 0;
    for (i = 0; i < array.GetLength(0); i++)
    {
        if (i == coordinate[0])
        {
            continue;
        }
        else
        {
            jndex = -1;
            for (j = 0; j < array.GetLength(1); j++)
            {
                if (j == coordinate[1]) continue;
                else
                {
                    jndex++;
                }
                newarray[index, jndex] = array[i, j];
            }
            index++;
        }
    }
    return newarray;

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


int[,] matrix = FillArray(4, 6, 0, 10);
// Выводим массив
PrintArrayTwo(matrix);
int[] coordinate = FindMin(matrix);
int[,] newarray = DeleteRowsAndColunsArrayTwo(matrix, coordinate);
Console.WriteLine();
PrintArrayTwo(newarray);