// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)



int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine("Исходный массив:");
PrintArray(array);

// Переворачиваем массив
ReverseArray(array);

Console.WriteLine("Перевернутый массив:");
PrintArray(array);

Console.ReadLine();


// Метод для переворачивания массива
static void ReverseArray(int[] array)
{
    int left = 0, right = array.Length - 1;

    while (left < right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;

        left++;
        right--;
    }
}

// Метод для вывода массива
static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

