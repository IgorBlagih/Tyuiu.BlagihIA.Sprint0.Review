namespace Tyuiu.BlagihIA.Sprint3.TaskReview.V4.Lib
{
    public class DataService
    {
        public double[] Calculate(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;

            double[] valueA;
            valueA = new double[len];

            double y = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) + x) == 0)
                {
                    valueA[count] = 0;
                    count++;

                }
                else
                {
                    y = Math.Round(((2 * x + 6) / (Math.Cos(x) + x)) - 3, 2);
                    valueA[count] = y;
                    count++;
                }
            }
            return valueA;
        }
    }
}
