using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GulienkoPO.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {

        public double LoadFromDataFile(string path)
        {
            var n = File.ReadAllText(path);
            double x = double.Parse(n.Replace('.', ','));
            double result = Math.Cos(x) + Math.Pow(x, 2) - 2 * x / 1.2;
            return Math.Round(result, 3);
        }
    }
}
