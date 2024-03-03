// Быстрая сортировка O(n * log2(n))
// Напишите программу, которая сложит натуральные числа a и b без прямого сложения
/*
Структура программного кода:
Импорт всех модулей/библиотек
Создание объектов и их методов
Функии и процедуры
Основной программный код
*/
// int sumNumbers(int a, int b){
//     if (b == 0)
//         return a;
//     return sumNumbers(a + 1, b - 1);
// }
// /* f = sumNumbers
// f(5, 3) -> f(6, 2) -> f(7, 1) -> f(8, 0) -> 8
// */

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n} + {m} = {sumNumbers(n, m)}");

// Найти n-ое число Фибоначчи
// f(n) = f(n - 1) + f(n - 2)
// 0 1 1 2 3 5 8 13 21 34 55
// 0 1 2 3 4 5 6 7  8  9


// int fib(int n){
//     if (n == 0 || n == 1)
//         return n;
//     return fib(n - 1) + fib(n - 2);
// }
// /*
// O(2^n)
// n = 5
// fib(5) -> fib(4) + fib(3) = 3 + 2 = 5
//           |             |
//           |             fib(2) + fib(1) = 1
//           |                |
//   2=fib(3) + fib(2)  fib(1) + fib(0)
//      |           |
// fib(2) + fib(1)  fib(1) + fib(0)  
// |           1       1       0
// fib(1) + fib(0) = 1 + 0
// |           | 
// 1           0
// */
// Console.Clear();
// Console.Write("Введите номер: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(fib(n));
// int a0 = 0, a1 = 1, aNext;
// // O(n)    O(10)
// // O(2^n)  O(1024)
// for (int i = 0; i < n; i++){ // выполнится n раз
//     Console.Write($"{a1} ");
//     aNext = a0 + a1;
//     a0 = a1;
//     a1 = aNext;
// }
/*
a0 = 0
a1 = 1
aNext = a0 + a1 = 0 + 1 = 1
a0 = a1 = 1
a1 = aNext = 1
aNext = a0 + a1 = 1 + 1 = 2
a0 = a1 = 1
a1 = aNext = 2
....
*/

/* Алгоритм Быстрой Сортировки
array = [7, 4, 1, 3, 5, 2, 8, 6]
pivot = array[0]
[4, 1, 3, 5, 2, 6] + [7] + [8] = [] + [1] + [2] + [3] + [] + [4] + [] + [5] + [6] + [7] + [8]

array = [4, 1, 3, 5, 2, 6]
pivot = array[0] = 4
[1, 3, 2] + [4] + [5, 6]

array = [1, 3, 2]
pivot = 1
[] + [1] + [3, 2]


array = [3, 2]
pivot = 3
[2] + [3] + []


array = [5, 6]
pivot = 5
[] + [5] + [6]
*/

int[] Concat(int[] a, int[] b, int[] c)
{
    int[] result = new int[a.Length + b.Length + c.Length];
    for (int i = 0; i < result.Length; i++)
    {
        if (i < a.Length)
        {
            result[i] = a[i];
        }
        else if (i >= a.Length && i < a.Length + b.Length)
        {
            result[i] = b[i - a.Length];
        }
        else
        {
            result[i] = c[i - a.Length - b.Length];
        }
    }
    return result;
}

int[] QuickSort(int[] array)
{
    if (array.Length < 2)
    {
        return array;
    }
    else
    {
        int pivot = array[0];
        int count = 0;
        foreach (int element in array)
        {
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < pivot)
            {
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array)
        {
            if (element > pivot)
                count++;
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > pivot)
            {
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array)
        {
            if (element == pivot)
                count++;
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++)
        {
            pivotArray[i] = pivot;
        }
        int[] result = Concat(QuickSort(less), pivotArray, QuickSort(greater));
        return result;
    }
}

int[] CreateArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int CountDigitsQuantity(int[] array, int n)
{
    int count = 0;
    foreach(int item in array)
    {
        if(item == n)
        {
            count++;
        }
    }
    return count;
}

int InputNumber()
{
    int number;
    while (true)
    {
        string input = Console.ReadLine()!;
        if(IsInputDigit(input))
        {
            number = int.Parse(input);
            break;
        }
        else
        {
            Console.WriteLine("Нужно ввести целое число, попробуйте ещё раз.");
        }
    }
    return number;
}

bool IsInputDigit(string number)
{
    bool flag = false;
    foreach (char e in number)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            flag = true;
        }
    }
    return flag;
}

Console.Clear();
Console.WriteLine("Приветствую Вас, уважаемый пользователь!\nЭто программа для сортировки чисел в массиве,\nот меньшего значения до большего.");
Console.WriteLine();
Console.WriteLine("Введите минимальное значение массива:");
int min = InputNumber();
Console.WriteLine("Введите максимальное значение массива:");
int max = InputNumber();
Console.WriteLine("Введите количество элементов в массиве:");
int size = InputNumber();
int[] array = CreateArray(min, max, size);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсростированный массив: [{string.Join(", ", QuickSort(array))}]");
Console.WriteLine();
Console.WriteLine("Введите число, количество которого хотите узнать:");
int find = InputNumber();
Console.WriteLine($"Количество чисел {find} в нашем массиве: {CountDigitsQuantity(array, find)}");