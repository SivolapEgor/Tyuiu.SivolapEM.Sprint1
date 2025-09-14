using Tyuiu.SivolapEM.Sprint1.Task3.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int amountNotebook, amountPencil;
        double priceNotebook, pricePencil;

        Console.Title = "Спринт #1 | Выполнил: Сиволап Е. М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет стоимость покупки, состоящей из   *");
        Console.WriteLine("* нескольких тетрадей и карандашей.                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("\nСтоимость тетрадей -> ");
        priceNotebook = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nКол-во тетрадей -> ");
        amountNotebook = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nСтоимость карандашей -> ");
        pricePencil = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nКол-во карандашей -> ");
        amountPencil = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
        Console.WriteLine("Стоимость покупки -> " + res);
    }
}