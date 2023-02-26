// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int num = 7;
int[] array = Array(num);
//Console.WriteLine($"[{String.Join(", ", array)}]");

int[] Array(int size)

{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

int res = 0;
int SumNumbers(int res)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 == 1)
        {
            res = array[j] + res;
        }

    }
    return res;
}
Console.WriteLine($"[{String.Join(", ", array)}] -> {SumNumbers(res)}");
