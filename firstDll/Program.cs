using MyLib;

biblioteka math = new biblioteka();
math.PrintMultiplicationTable(7);
math.CheckEvenOdd(15);
double area = math.CalculateCircleArea(5);
Console.WriteLine($"Площадь круга: {area}");
try
{
    long factorial = math.CalculateFactorial(6);
    Console.WriteLine($"Факториал 6: {factorial}");
}
catch (ArgumentException ex)//в случае ввода некорректных данных, программа вернет исключение
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
string leapYearMessage = math.IsLeapYear(2024);
Console.WriteLine(leapYearMessage);





