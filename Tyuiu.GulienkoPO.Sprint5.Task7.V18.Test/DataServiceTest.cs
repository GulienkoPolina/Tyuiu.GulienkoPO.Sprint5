using Tyuiu.GulienkoPO.Sprint5.Task7.V18.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\бебе\source\repos\Tyuiu.GulienkoPO.Sprint5\Tyuiu.GulienkoPO.Sprint5.Task7.V18\bin\Debug\net8.0\DataSprint5\InPutDataFileTask7V18.txt"

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}