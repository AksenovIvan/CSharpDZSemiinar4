// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumingNumbers(int a)
{
    int sum = 0;
    for (int i = a; i > 0; i/=10)
    {
        sum = i % 10 + sum;
    }
    return sum;
}

int result = SumingNumbers(userNumber);
System.Console.WriteLine($"Сумма цифр числа {userNumber} равна {result}");