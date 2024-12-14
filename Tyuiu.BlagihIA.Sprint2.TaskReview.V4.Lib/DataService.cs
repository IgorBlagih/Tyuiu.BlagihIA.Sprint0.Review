namespace Tyuiu.BlagihIA.Sprint2.TaskReview.V4.Lib
{
    public class DataService
    {
        public static bool DotFind(double x, double y)
        {
            bool res;
            if (((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (0.3 <= (Math.Pow(x, 2) + Math.Pow(y, 2))) &&(Math.Sqrt(x)+ Math.Sqrt(y)>=0 ))||
                (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && y>0 && x<0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
