using Tyuiu.BlagihIA.Sprint6.TaskReview.V4.Lib;
using System.IO;
using System.Data;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
namespace Tyuiu.BlagihIA.Sprint6.TaskReview.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            Class1 ds = new Class1();
            int[,] array = new int[4, 4] {{1,2,3,4},
                                          {4,4,5,1},
                                          {1,3,3,8}, 
                                          {1,4,5,6}};

            int c = 3;
            int n1 = 1;
            int n2 = 3;
            int k = 0;
            int l = 3;

            double res = ds.Calculate(array, n1, n2, c, k, l);

            double wait = 18;

            Assert.AreEqual(wait, res);

        }

        
    }
}