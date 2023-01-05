// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// <aside>
// ❗ **Числа Фибоначчи** — числовая ****последовательность, каждый элемент которой равен сумме двух предыдущих.
// </aside>

int[] CreateMassive(int n) { 
    int[] array = new int[n]; 
    array[0] = 0; 
    array[1] = 1; 
    for (int i = 2; i < n; i++) { 
        array[i] = array[i-2] + array[i-1]; 
    } 
    return array; 
} 
 
int GetNumber(string text) { 
    Console.WriteLine(text); 
    int number = int.Parse(Console.ReadLine()); 
    return number; 
} 
 
int a = GetNumber("Введите число: "); 
int[] way = CreateMassive(a); 
Console.WriteLine($"[{string.Join(", " , way)}]");