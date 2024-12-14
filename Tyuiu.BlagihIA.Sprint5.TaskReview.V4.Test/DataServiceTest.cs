using Tyuiu.BlagihIA.Sprint5.TaskReview.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint5.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethodIN()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V4.txt");

            FileInfo inf = new FileInfo (path);
            bool fileexist = File.Exists (path);
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }



        [TestMethod]
        public void TestMethodOUT()
        {
            string path = Path.Combine("C:", "DataSprint5", "OutPutDataFileTask7V4.txt");

            FileInfo inf = new FileInfo(path);
            bool fileexist = File.Exists(path);
            bool wait = true;
             
            Assert.AreEqual(wait, fileexist);
        }
    }
}