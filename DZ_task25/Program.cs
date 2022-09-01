// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число: ");
int number_A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_B = int.Parse(Console.ReadLine());
int num = 1;

int function(int prz)
{
    for (int i = 1; i <=number_B; i++)
    {
        prz = prz * number_A;
    }
    return prz;
}
Console.WriteLine($"{function(num)}");