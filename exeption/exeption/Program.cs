using System;

public class ExceptionHandlingExample
{
    public static void Main(string[] args)
    {
        try
        {
            string input = "abc";
            int number = int.Parse(input); // Попытка преобразовать строку в число
            Console.WriteLine($"Число: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка преобразования: {ex.Message}");
        }
    }
}

