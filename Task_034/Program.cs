// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int num = 6;
int[] array = GetBinaryArray(num);
//Console.WriteLine($"[{String.Join(", ", array)}] -> {EvenNumbers}");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(99, 1000);
    }
    return result;
}

int res = 0;
int EvenNumbers(int res)
{
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
            res++;

    }
    return res;
}
Console.WriteLine($"[{String.Join(", ", array)}] -> {EvenNumbers(res)}");

//Console.WriteLine(EvenNumbers(res));