using Tyuiu.BlagihIA.Sprint2.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint2.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0.5;
            double y = 0.5;
            bool res = DataService.DotFind(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}