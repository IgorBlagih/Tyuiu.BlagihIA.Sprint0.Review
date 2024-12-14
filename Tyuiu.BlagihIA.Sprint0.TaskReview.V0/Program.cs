using Tyuiu.BlagihIA.Sprint0.TaskReview.V0.Lib;
namespace Tyuiu.BlagihIA.Sprint0.TaskReview.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите z:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nФормула: (x+y+z)*5");
            Console.WriteLine("\nРезультат:" + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
