// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void printArray (int[] array)
{
    string ourArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        ourArray += array[i];
        if (i != array.Length - 1) ourArray += ", ";
    }
    Console.WriteLine(ourArray);
}

int[] getArray()
{
    int[] intArray = new int[8];    
    for (int i = 0; i < intArray.Length; i++)
    {
        int randInd = new Random().Next(0, 2);
        intArray[i] = randInd;
    }
    return intArray;
}

void main()
{
    int[] array = getArray();
    printArray(array);
}

main();