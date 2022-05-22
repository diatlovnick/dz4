/*
Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

int Getnumber(string msg)
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

int a = Getnumber("Введие первое число A");
int b = Getnumber("Введите второе число B");
int resault = a;

for (int i = 1; i < b; i++)
{
    resault = resault * a;
}
Console.WriteLine(resault);

 
/*
Попытался сделать через функцию с вводом двух переменных, но не получилось, без функии всё работает

Console.WriteLine("Введите первое число А");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первое число B");
double B = Convert.ToDouble(Console.ReadLine());
double GetDegree(double A);
{
    double degree = Math.Pow(A, B);
    return degree;
}
double resault = GetDegree(A, B);


Console.WriteLine(resault);
*/


