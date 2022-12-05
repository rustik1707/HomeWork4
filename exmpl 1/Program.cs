/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/


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



int a = Getnumber("введите первое число");
int b = Getnumber("введите второе число");;
int res = a;
for (int i = 2; i<= b; i++)
    {
        res = res*a;

    }





Console.WriteLine($"итог равен {res}");








    
   