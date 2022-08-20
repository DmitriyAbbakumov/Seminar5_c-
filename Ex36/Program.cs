/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void Fill(int[] array)              //метод: заполняем массив случайными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
void uneven(int[] arr)              //метод: находим сумму эл-тов с нечетными индексами
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arr[i];
    }
    Console.WriteLine(sum);
}
Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
Fill(massiv);
uneven(massiv);

