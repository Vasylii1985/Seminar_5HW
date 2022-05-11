//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine();

int size = 5;

Console.WriteLine($"Количетсов элементов массива: {size}");

int[] FillSourceArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintDiffMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    int difference = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение массива = {arr.Min()}, максимальное значение массива = {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива = {difference}");
}

PrintDiffMinMax(FillSourceArray(size));
Console.WriteLine();
