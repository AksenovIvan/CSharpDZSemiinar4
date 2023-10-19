// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int[] CreatArray(int length)
{
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,99);
    }
    return array;
}

void PrintArray(int[]massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        System.Console.Write($"{massiv[i]}, ");
    }
}

System.Console.WriteLine("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreatArray(arraySize);
PrintArray(array1);
