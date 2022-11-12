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
        int sum = 0;
        int num_last = default;
        while (num > 0)
            {
                num_last = num % 10;
                num = num / 10;
                sum = sum + num_last;
                Console.Write($"{num_last} ");
            }   
        return sum;
    }


