using System.ComponentModel.DataAnnotations;
using Tyuiu.BlagihIA.Sprint3.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint3.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 1;

            int  len = (stop- start) + 1;
            double[] vArray; 
            vArray = new double[len];

            vArray[0] = 2.19;

            double[] res = new double[len];
            res = ds.Calculate(start, stop);
            CollectionAssert.AreEqual(vArray, res);
        }
    }
}