// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[100];
Random r = new Random();
int count = 0;
System.Console.WriteLine("Cгенерированный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(100, 999);
    //System.Console.WriteLine("Cгенерированный массив:");
    System.Console.Write(array[i] + " ");
}
//int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    
    }

}
System.Console.Write($"Количество четных чисел в массиве: {count}");