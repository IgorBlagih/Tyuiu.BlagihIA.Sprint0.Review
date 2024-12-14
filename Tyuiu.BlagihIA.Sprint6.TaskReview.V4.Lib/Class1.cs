namespace Tyuiu.BlagihIA.Sprint6.TaskReview.V4.Lib
{
    public class Class1
    {
        public double Calculate(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            

            if((n1>n2) || (l<k) ||(c>cols))
            {
                throw new InvalidOperationException("Некорректный ввод данных n1, n2, k, l");
            }
            

            double result = 0;
            for (int i=k; i<rows; i++)
            {
                for (int j = c; j <= c; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        result += array[i, j];
                    }
                }
            }
            return result;
        }

        public int[,] GetMatrix(int N, int M, int n1, int n2)
        {
            int rows = N;
            int cols = M;
            string[] str = { "" };
            string arr = "";
            Random rnd = new Random();



            int[,] array = new int[rows, cols];

           



            for (int i = 0; i < rows; i+=2)
            {
                for (int j = 0; j < cols; j+=2)
                {
                    {
                            array[i, j] = rnd.Next(n1, n2);
                            while (array[i, j] % 2 == 0)
                            {
                                array[i, j] = rnd.Next(n1, n2);
                            }


                    }
                }
            }

            for (int i = 0; i < rows; i+=2)
            {
                for (int j = 1; j < cols; j += 2)
                {
                    {
                        array[i, j] = rnd.Next(n1, n2-1);
                        while (array[i, j] % 2 != 0)
                        {
                            array[i, j] = rnd.Next(n1, n2-1);
                        }


                    }
                }
            }



            for (int i = 1; i < rows; i += 2)
            {
                for (int j = 0; j < cols; j += 2)
                {
                    {
                        array[i, j] = rnd.Next(n1, n2-1);
                        while (array[i, j] % 2 != 0)
                        {
                            array[i, j] = rnd.Next(n1, n2);
                        }


                    }
                }
            }

            for (int i = 1; i < rows; i += 2)
            {
                for (int j = 1; j < cols; j += 2)
                {
                    {
                        array[i, j] = rnd.Next(n1, n2 );
                        while (array[i, j] % 2 == 0)
                        {
                            array[i, j] = rnd.Next(n1, n2-1);
                        }


                    }
                }
            }
            return array;

        }
    }
}
