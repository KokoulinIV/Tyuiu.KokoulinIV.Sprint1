using Tyuiu.KokoulinIV.Sprint1.Task7.V0.Lib;
namespace Tyuiu.KokoulinIV.Sprint1.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на С#, которая запрашивает у пользователя переменную *");
            Console.WriteLine("* вычисляет по формуле и выводит результат на экран                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*         7x^2                                                            *");
            Console.WriteLine("* z = x - ____  + sin(x) + |x^4 - x^5|                                    *");
            Console.WriteLine("*         x^3                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите переменную");
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.Calculate(z));
        }
    }
}
