//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();
void AnyStepen(int a, int b)
{
        System.Console.WriteLine($"Если {a} возвести в степень {b}, то получится {Math.Pow(a, b)}");
}

System.Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень:");
int userStepen = Convert.ToInt32(Console.ReadLine());
AnyStepen(userNumber,userStepen);
