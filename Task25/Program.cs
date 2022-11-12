//Задача 25.
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Clear();
Console.Write("введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degreeOfNumbers = DegreeOfNumbers(numberA, numberB);
Console.WriteLine($"число {numberA} в степени {numberB} -> {degreeOfNumbers}");

//метод for
int DegreeOfNumbers (int numA, int numB)
{
    int degree = 1;
    for (int i = 1; i <= numB; i++)
    {
        degree = degree * numA;
    }
    return degree;
} 

//метод while
// int DegreeOfNumbers (int numA, int numB)
// {
//     int degree = 1;
//     int counter = 1;
//     while (counter <= numB)
//     {
//         degree = degree * numA;
//         counter++;
//     }
//     return degree;
// } 
