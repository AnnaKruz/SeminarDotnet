// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] SumNumber(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = -array[i]; 
    } 
    return array; 
} 
 
int[] CreateMassive(int count, int begin, int end) { 
    int[] array = new int[count]; 
    for (int i = 0; i < count; i++) { 
        array[i] = new Random().Next(begin, end+1); 
    } 
    return array; 
} 
 
int[] way = CreateMassive(12, -9, 9); 
Console.WriteLine($"[{string.Join(", " , way)}]"); 
int[] sumPlus = SumNumber(way); 
Console.WriteLine($"[{string.Join(", " , way)}]");