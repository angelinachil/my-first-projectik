using System;

public class ExceptionHandlingExample
{
    public static void Main(string[] args)
    {
        // Получаем число от пользователя для вычисления факториала
        Console.WriteLine("Введите число для вычисления факториала:");
        string input = Console.ReadLine();

        try
        {
            // Генерируем случайное число вместо чтения из файла
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Случайное число от 1 до 100

            // Попытка преобразовать строку в число и вычислить факториал
            int numberFromInput = int.Parse(input);
            long factorial = CalculateFactorial(numberFromInput);

            // Вывод результатов
            Console.WriteLine($"Случайное число: {randomNumber}");
            Console.WriteLine($"Факториал числа {numberFromInput}: {factorial}");
            Console.WriteLine($"Сумма чисел: {randomNumber + numberFromInput}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: Неверный формат ввода. {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
    }

    // Метод для вычисления факториала (без изменений)
    static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал не определен для отрицательных чисел.");
        }
        if (n == 0)
        {
            return 1;
        }
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}



