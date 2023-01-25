/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
string message = "Введите цифру";
int GetNumber(string message)
{
    int resultNumber = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber))
        {
        break;
        }
        else
        {
            Console.WriteLine("ВВели не число или не коректное число. Повторите ввод.");
        }
    }
    return resultNumber;
}

int numberDay = GetNumber(message);
int CheckHolidays(int numberDay)
{
    if (numberDay > 7)
    {
    Console.WriteLine("Введено не корректное число");
    }
    else if (numberDay < 8 & numberDay >= 6)
    {
        Console.WriteLine("Ура! Сегодня выходной");
        }
    else if (numberDay < 6)
    {
        Console.WriteLine("Сегодня будни");
        }
    return numberDay;
}
int Checkout = CheckHolidays(numberDay);
