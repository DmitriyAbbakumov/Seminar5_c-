/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

void Fill(double[] arr)         //метод: заполняем массив случаными вещественными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 100) + Math.Round(new Random().NextDouble(), 2);
        Console.Write($" {arr[i]}");
    }
}
void diffMinMax(double[] arr)   //метод: находим разницу max-min
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine(Math.Round((max - min), 2));
}

Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] massiv = new double[N];
Fill(massiv);
Console.WriteLine();
diffMinMax(massiv);