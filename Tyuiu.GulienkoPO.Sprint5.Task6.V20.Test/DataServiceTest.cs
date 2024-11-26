using Tyuiu.GulienkoPO.Sprint5.Task6.V20.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\бебе\source\repos\Tyuiu.GulienkoPO.Sprint5\Tyuiu.GulienkoPO.Sprint5.Task6.V20\bin\Debug\net8.0\DataSprint5\InPutDataFileTask6V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}