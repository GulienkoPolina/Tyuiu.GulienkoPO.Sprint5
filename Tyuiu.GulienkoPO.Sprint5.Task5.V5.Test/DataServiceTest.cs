using System.IO;
using Tyuiu.GulienkoPO.Sprint5.Task5.V5.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"""C:\DataSprint5\InPutDataFileTask5V5.txt.txt""";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}