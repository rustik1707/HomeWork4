/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

int Getnumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);    
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
    
        else 
        {
            Console.WriteLine("ввели некорректную команду");
        }
    }
    return result;

}


int number = Getnumber("напишите число");

int sum = 0;
 while (number > 0)
    {
 
    sum = sum + number % 10;
    number = number /10 ;
 
    }
 Console.WriteLine($"сумма цифр чила равна:{sum}");
