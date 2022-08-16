//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] array1 = new int[8];
Console.WriteLine("Случайный массив из 8 элементов в диапазоне [0,100]: ");
for (int i = 0; i < 8; i++)
{
    array1[i] = new Random().Next(0,100);
    Console.Write (array1[i] + " ");
}
Console.WriteLine();
