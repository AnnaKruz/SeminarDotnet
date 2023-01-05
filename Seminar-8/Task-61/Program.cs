//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
void MatrixProduct(int[,] array, int[,] matrix)
{
    int[,] prodArray = new int[array.GetLength(0), matrix.GetLength(1)];
    if (array.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Произведение матриц не возможно");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(0); ++j)
            {
                for (int k = 0; k < matrix.GetLength(1); ++k)
                {
                    prodArray[i, k] += array[i, j] * matrix[j, k];
                }
            }
        }
        PrintArrayTwo(prodArray);
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
            array[i, j] = new Random().Next(begin, end + 1);
        }
    }
    return array;
}

int[,] matrix1 = FillArray(3, 4, 0, 5);
PrintArrayTwo(matrix1);
Console.WriteLine();
int[,] matrix2 = FillArray(1, 3, 0, 5);
PrintArrayTwo(matrix2);
Console.WriteLine();
MatrixProduct(matrix1, matrix2);