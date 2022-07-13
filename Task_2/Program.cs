//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Enter array size :");
int arraySize = Convert.ToInt32(Console.ReadLine());
int [] array = new int [arraySize];
Random randomNumbers = new Random();
for(int i = 0; i < arraySize; i++)
{
    array[i] = randomNumbers.Next(1000);
}
Console.WriteLine($"[{String.Join(";", array)}]");
int sumElements = 0;
for (int i = 1; i < arraySize; i = i + 2)
{
    sumElements = sumElements + array[i];
}
Console.WriteLine($"The sum of the elements standing in odd positions = {sumElements}");

