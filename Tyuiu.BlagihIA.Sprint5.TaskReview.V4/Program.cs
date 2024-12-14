using Tyuiu.BlagihIA.Sprint5.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint5.TaskReview.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Благих И.А | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все русские буквы в файле на #. Полученный результат сохранить *");
            Console.WriteLine("* в файл OutPutDataSprintFileTask7V4.txt                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V4.txt"); 
            string outpath = Path.Combine("C:", "DataSprint5", "OutPutDataFileTask7V4.txt");
            Console.WriteLine($"* {path}                                 *");
            Console.WriteLine($"* {outpath}                                *");

            string res = ds.FIleWork(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            File.WriteAllText(outpath, res);
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
