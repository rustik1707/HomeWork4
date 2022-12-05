// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int []createArray(int numbers)
{
    int []array = new int[numbers];
    Random rnd = new Random();

    for (int i = 0; i < numbers; i++)
    {
        array[i] = rnd. Next(0,101);
    }

return array;

}


void printArray(int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }


}

int []array = createArray(8);
printArray(array);

