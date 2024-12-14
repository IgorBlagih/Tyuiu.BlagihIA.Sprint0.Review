using Tyuiu.BlagihIA.Sprint3.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint3.TaskReview.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Благих И.А | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значения функции F(x)       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + stop);

            int len = ds.Calculate(start, stop).Length;

            double[] value;
            value = new double[len];

            value = ds.Calculate(start, stop);
            Console.WriteLine("* Результат:                                                              *");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("+    X     +    F(x)  +");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1,5:f2}   |", start++, value[i]);
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
