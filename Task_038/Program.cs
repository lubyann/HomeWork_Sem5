// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int num = 7;
int[] array = Array(num);
//int[] array = {3, 7, 22, 2, 78};
//Console.WriteLine($"[{String.Join(", ", array)}] -> {int difference = maxValue(max) - minValue(min)}");
//Console.WriteLine($"{maxValue(max)}");

int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

int max = 0;
int maxValue(int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            // найден больший элемент
            max = array[i];
        }
    }
    return max;
}
//Console.WriteLine($"Max -> {maxValue(max)}");

int min = array[0];
int minValue(int min)
{

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {

            min = array[i];
        }
    }
    return min;
}
//Console.WriteLine($"Min -> {minValue(min)}");

int res = 0;
int difference(int res)
{
    if (minValue(min) < 0)
    {
        res = maxValue(max) + minValue(min);
    }
    else
    {
        res = maxValue(max) - minValue(min);  
    }
    return res;
}

Console.WriteLine($"[{String.Join(", ", array)}] -> {difference(res)}");
Console.WriteLine($"Max Value -> {maxValue(max)}");
Console.WriteLine($"Min Value -> {minValue(min)}");