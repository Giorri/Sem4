// Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int [] Massive()
{
    Console.WriteLine("Задайте длину массива: ");
    int number_N = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте нижнее предельное число: ");
    int number_A = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте верхнее предельное число: ");
    int number_B = int.Parse(Console.ReadLine());
    int [] Massive = new int[number_N];
    for (int i=0; i < Massive.Length; i++)
    {
        Massive[i] = new Random().Next(number_A,number_B);
    }
    return Massive;
}

void Print(int [] Massive)
{
    for (int i=0; i < Massive.Length; i++)
    {
        Console.Write($"{Massive[i]}, ");
    }
}

Print(Massive());