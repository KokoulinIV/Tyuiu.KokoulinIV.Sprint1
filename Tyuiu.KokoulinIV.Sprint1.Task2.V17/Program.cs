
using Tyuiu.KokoulinIV.Sprint1.Task2.V17.Lib;

namespace Tyuiu.KokoulinIV.Sprint1.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на С#, которая запрашивает у пользователя данные ,   *");
            Console.WriteLine("* вычисляет выражение колличество полных часов из минут                   *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  1ч = 60 мин                                                            *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите колличество минут");
            int x = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ConvertMinutesToHours(x));

            Console.ReadKey();
        }
    }
}
