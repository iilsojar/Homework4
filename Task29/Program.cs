// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//(в примере показаны два разных массива, создаем именно для 8 элементов)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];
FillArray(array);
PrintArray(array);

void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = 1;
    }
}
void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{i} ");
    }
}
