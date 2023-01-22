/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ShowSecondNumber(int number)
{
    int firstAction = (number / 10);
    return (firstAction % 10);
}

int number1 = GetNumber();
int result = ShowSecondNumber(number1);

Console.WriteLine($"Вторая цифра = {result}");