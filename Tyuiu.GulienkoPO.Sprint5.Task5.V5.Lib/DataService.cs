using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GulienkoPO.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            int minInt = 0;
            int maxInt = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        if (number < minInt)
                        {
                            minInt = number;
                        }
                        if (number > maxInt)
                        {
                            maxInt = number;
                        }
                    }
                }
            }
            int diffInt = maxInt - minInt;
            return diffInt;
        }
    }
}