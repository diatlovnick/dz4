/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
Понимаем условие задачи как: создать массив из случайного количесвта элементов(от 1 до 10) заполненным случайными числами от 1 до 99
*/


void FillArray(int[] collection)
{ 
    Random randomasier = new Random();
    for (int i=0; i < collection.Length; i++)
    {
        collection[i] = randomasier.Next(0, 100);
    }
}

int randomLength = new Random().Next(1,11);
int[] array = new int[randomLength];
FillArray(array);

for (int i=0; i < array.Length; i++)
{
    Console.Write(array[i] + " " );
}

/* вариант программы когда массив создаётся из полученных данных
int GetNumber(string msg)
{
    Console.WriteLine(msg);
    while(true)
    {
        string valueFromConsole = Console.ReadLine();
        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }

    }
}

int lengthArray = GetNumber("введите длину массива");
int[] array = new int[lengthArray];

for (int i = 0; i < lengthArray; i++)
{
    int number = GetNumber("введите элемент массива");
    array[i] = number;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " " ); 
}
*/