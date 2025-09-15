using Tyuiu.SivolapEM.Sprint1.Task1.V16.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сиволап Е. М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле x*5*a+2*y и печатает его на экране.      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double a, x, y;
        Console.Write("\nВведите значение a -> ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nВведите значение x -> ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nВведите значение y -> ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        Console.WriteLine(dataService.Calculate(a,x,y));
        Console.ReadKey();
    }
}