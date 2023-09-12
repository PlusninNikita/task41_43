// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//1. Получаю размер массива (с проверкой не менее 0)
//2. Формирую алгоритм который будет создавать массив с размером N
//3. Формирую цикл который будет создавать N пользовательских запросов
//4. Считаю сколько элементов в массиве меньше 0.

int[] RequestUserArray()
{
    int size = 0;
    Console.WriteLine("Создание нового массива данных");
    Console.Write("Введите размер массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    while (size < 1)
    {
        Console.WriteLine("Ошибка: размер должен быть больше нуля!");
        Console.Write("Введите размер массива: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    int[] arr = new int[size];
    return arr;
}

void ManuallyFillArray (int[] arr)
{
    Console.WriteLine($"Заполните массив натуральными числами {arr.Length} раз");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Элемент {1+i} из {arr.Length}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());  
    }
}

int CountNegativeElement(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] array = RequestUserArray();
ManuallyFillArray(array);
Console.WriteLine();
PrintArray(array);
int negativeElement = CountNegativeElement(array);
Console.WriteLine();
Console.WriteLine($"Количество элементов в массиве меньше нуля: {negativeElement} шт.");