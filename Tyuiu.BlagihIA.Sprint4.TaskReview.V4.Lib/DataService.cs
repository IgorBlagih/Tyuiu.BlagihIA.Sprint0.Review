namespace Tyuiu.BlagihIA.Sprint4.TaskReview.V4.Lib
{
    public class DataService
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int[,] mtrx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i,j] = int.Parse(value[i*m+j].ToString());

                    if (mtrx[i,j]% 2 != 0)
                    {
                        sum += mtrx[i,j];
                    }
                }
            }
            return sum;
        }
    }
}
