﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19



Console.WriteLine();
int size = 4;

int[] FillArray( int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArrayAndSum(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + "; ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
}

PrintArrayAndSum(FillArray(size));