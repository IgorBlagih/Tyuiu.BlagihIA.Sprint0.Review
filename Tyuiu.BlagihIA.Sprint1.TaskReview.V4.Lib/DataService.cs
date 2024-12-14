namespace Tyuiu.BlagihIA.Sprint1.TaskReview.V4.Lib
{
    public class DataService
    {
        public static double Calculate(double x, double y)
        {
            return Math.Round(Math.Log(Math.Abs((y-Math.Sqrt(Math.Abs(x)) )*(x-(y/(x+(Math.Pow(x, 2)/4)))))),3);
        }
    }
}
