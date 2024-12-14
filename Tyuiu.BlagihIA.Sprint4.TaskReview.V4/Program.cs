using Tyuiu.BlagihIA.Sprint4.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint4.TaskReview.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Благих И.А | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из цифр. Преобразуйте ее в матрицу 3 на 4 и подсчитайте     *");
            Console.WriteLine("* сумму нечетных чисел                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "382976421897";
            Console.WriteLine(value);

            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* МАССИВ                                                                  *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i< rows; i++)
            {
                for (int j = 0; j< columns; j++)
                {
                    mtrx[i, j] = int.Parse(value[i * columns + j].ToString());
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(rows, columns, value);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
