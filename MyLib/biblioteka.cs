namespace MyLib
{
    public class biblioteka
    {
        public void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"Таблица умножения для {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        //Метод, проверяющий определенное число на четность(не возвращает значения)
        public void CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} - четное число.");
            }
            else
            {
                Console.WriteLine($"{number} - нечетное число.");
            }
        }
        /*Метод, возвращающий значение, вычисляющий площадь круга*/
        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        /*Метод, вычисляющий факториал*/
        public long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
            }
            if (n == 0) return 1;
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        /*Метод, проверяет год на високосность*/
        public string IsLeapYear(int year)
        {
            bool isLeap = DateTime.IsLeapYear(year);
            return $"{year} {(isLeap ? "високосный" : "не високосный")} год.";
        }
    }
}
