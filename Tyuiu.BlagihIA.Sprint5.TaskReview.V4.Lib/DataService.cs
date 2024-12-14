namespace Tyuiu.BlagihIA.Sprint5.TaskReview.V4.Lib
{
    public class DataService
    {
        public string FIleWork(string path)
        {
            string strx = File.ReadAllText(path);


            foreach (char c  in strx)
            {
                if ((c >= 'А' && c <= 'Я')|| (c >= 'а' && c <= 'я'))
                {
                    strx = strx.Replace(c, '#');

                }    
            }
            return strx;
        }
    }
}
