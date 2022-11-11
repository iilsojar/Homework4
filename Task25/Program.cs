//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfNumbers = SumOfNumbers(number);
Console.WriteLine($"сумма цифр в числе {number} -> {sumOfNumbers}");

int SumOfNumbers (int num)
{
    int count = 0;
    int sum = 0;
    while (num >= 0)
    {
        num = num / 10;
        sum = sum + num;
        count ++;
    }
    return sum;
}



