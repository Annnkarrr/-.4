// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при 
//вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.




int CalculateSum(int Number)
{
    int sum = 0;
    while ( Number != 0)
    {
        int digit = Number % 10;
        sum += digit;
        Number /= 10;
    }
    return sum;
}


    while (true)
    {
        Console.WriteLine("Введите целое число: ");
        string userInput = Console.ReadLine();

        if (userInput == "q")
            break;

        int Number = Convert.ToInt32(userInput);
        if ( CalculateSum(Number) % 2 == 0)
            Console.WriteLine("Сумма чисел четная. Вы выходите из системы!!!");
            break;
    }



