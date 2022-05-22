/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

int number = GetNumber("Введите число");
string numberstr = Convert.ToString(number);// если использовать второе решение, то эту строку нужно закоментировать
int resault = GetSum(numberstr); // а в этой строке numberstr поменять на number
Console.WriteLine($"{number} -> {resault}");


/* другой вариант решения, без применения string.Lenth
int GetSum(int number)
{
    int currentNumber;
    int sum = 0;
    while (number > 0)
    {         
        currentNumber = number % 10;
        sum = sum + currentNumber;
        number = number / 10;

    }
    return sum;
}
    */
    int GetSum(string numberstr)
{
    int sum = 0;
    for (int i = 0; i < numberstr.Length; i++)
    {
        double numberdb = char.GetNumericValue(numberstr[i]);
        sum = sum + Convert.ToInt32(numberdb);
    }
    Console.WriteLine(sum);
    return sum;
    
}

int GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
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