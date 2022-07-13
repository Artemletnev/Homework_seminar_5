//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Enter array size: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arraysize];
Random randomNumber = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = randomNumber.NextDouble();
Console.WriteLine($"[{String.Join(";", array)}]");
double maxNumber = array[0];
double minNumber = array[0];
double difference = 0;
for(int i = 1; i < arraysize; i++)
{
    if( array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    else
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
}
Console.WriteLine($"Max number = {maxNumber}");
Console.WriteLine($"Min number = {minNumber}");
difference = maxNumber - minNumber;
Console.WriteLine($"The difference between the maximum and minimum is = {difference}");


