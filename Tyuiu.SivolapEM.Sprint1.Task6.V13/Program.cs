using Tyuiu.SivolapEM.Sprint1.Task6.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что буквы     *");
        Console.WriteLine("* строки упорядочены по алфавиту.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("\nВведите строку -> ");
        string value = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        string v = ds.CheckWordsAlphabet(value) ? "да" : "нет";
        Console.WriteLine($"Буквы упорядочены по алфавиту -> {v}");
        
    }
}