/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumber()
{
    Console.WriteLine("Введите число дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberDay = GetNumber();
if (numberDay > 7)
{
    Console.WriteLine("Введено не корректное число");
}
if (numberDay < 8 & numberDay >= 6)
{
    Console.WriteLine("Ура! Сегодня выходной");
}
if (numberDay < 6)
{
    Console.WriteLine("Сегодня будни");
}
