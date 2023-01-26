// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetMult(int A)
{
    int mult = 1;
    if (A > 0)
    {
        for (int i = 1; i <= A; i++)
        {
            mult *= i;
        }
    }
    
    return mult;
}

void main()
{
    Console.Write("Введите А: ");
    int n = int.Parse(Console.ReadLine()!);
    int mult = GetMult(n);
    Console.WriteLine($"{mult}");
}

main();