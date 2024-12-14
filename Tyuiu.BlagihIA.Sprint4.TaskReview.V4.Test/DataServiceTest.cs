using Tyuiu.BlagihIA.Sprint4.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint4.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string val = "123456789123";
            int n = 3;
            int m = 4;

            int wait = 29;
            int res = ds.Calculate(n, m, val);


            Assert.AreEqual(wait, res);
        }
    }
}