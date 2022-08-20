/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void Fill(int[] array)          //метод: заполняем массив трехзначными числами
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]}");
    }
}

void EvenNumbers(int[] arr)     //метод: ищем четные числа
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Четных чисел в массиве = {count}");
}
Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
Fill(massiv);
Console.WriteLine();
EvenNumbers(massiv);

