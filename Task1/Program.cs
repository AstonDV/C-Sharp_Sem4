// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int A)
{
    int sum = 0;
    if (A > 0)
    {
        for (int i = 1; i <= A; i++)
        {
            sum += i;
        }
    }
    
    return sum;
}

Console.Write("Введите А: ");
int n = int.Parse(Console.ReadLine()!);
int sum = GetSum(n);
Console.WriteLine($"{sum}");

