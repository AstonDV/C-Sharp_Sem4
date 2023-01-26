// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void main()
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.WriteLine(Result(num));
}


int Result(int number)
{
    if (number < 0) number *= -1;
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
main();
