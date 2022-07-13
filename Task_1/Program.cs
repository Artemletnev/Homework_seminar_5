//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Enter array size: ");
int arrayLenght = Convert.ToInt32(Console.ReadLine());
int [] array = new int[arrayLenght];
Random randomNumbers = new Random();
for(int i = 0; i < arrayLenght; i++)
{
    array[i] = randomNumbers.Next(100, 1000);
}
Console.WriteLine($"[{String.Join(";", array)}]");
int evenNumbers = 0;

for(int i = 0; i <arrayLenght; i++)
{
    if (array[i] % 2 == 0)
    {
        evenNumbers++;
    }
    
}
Console.WriteLine($"There are {evenNumbers} even numbers in the given array ");