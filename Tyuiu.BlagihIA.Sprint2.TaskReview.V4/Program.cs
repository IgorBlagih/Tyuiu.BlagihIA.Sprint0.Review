using Tyuiu.BlagihIA.Sprint2.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint2.TaskReview.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Благих И.А | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С# которая проверяет находится ли точка*");
            Console.WriteLine("*  в заштрихованной области по исходным данным                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());

            bool z = DataService.DotFind(x, y);
            Console.WriteLine("* Результат:                                                              *");
            
            if (z)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
        }
    }
}
