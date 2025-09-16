using Tyuiu.SivolapEM.Sprint1.Task5.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу: Дано значение      *");
        Console.WriteLine("* температуры в градусах Фаренгейта. Определить значение этой же          *");
        Console.WriteLine("* температуры в градусах Цельсия. Ответ привести к целому с помощью       *");
        Console.WriteLine("* класса Convert.                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double f;
        Console.Write("\nВведите значние температуры в градусах Фаренгейта -> ");
        f = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res;
        res = ds.FahrenheitToСelsius(f);
        Console.WriteLine($"Значние температуры в градусах Цельсия -> {res}");

    }
}