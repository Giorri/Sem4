// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int function_one(int num)
{
    int sum = 0;
    while (num > 0)
    {
       sum = sum + (num % 10);
       num = num / 10;
    }
    return sum;
}

Console.WriteLine($"{function_one(number)}");