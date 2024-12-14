using Tyuiu.BlagihIA.Sprint1.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint1.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            
            double x = 2;
            double y = 1;
            var res = DataService.Calculate(x, y);
            Assert.AreEqual(-0.371, res);
        }
    }
}