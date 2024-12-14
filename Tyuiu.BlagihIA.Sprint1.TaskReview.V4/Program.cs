using Tyuiu.BlagihIA.Sprint1.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint1.TaskReview.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Благих И.А | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С# которая вычислит математическое     *");
            Console.WriteLine("* выражение по исходным данным                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = DataService.Calculate(x, y);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("z = " + z);
        }
    }
}
