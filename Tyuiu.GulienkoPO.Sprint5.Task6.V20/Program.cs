using Tyuiu.GulienkoPO.Sprint5.Task6.V20.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = @"C:\Users\бебе\source\repos\Tyuiu.GulienkoPO.Sprint5\Tyuiu.GulienkoPO.Sprint5.Task6.V20\bin\Debug\net8.0\DataSprint5\InPutDataFileTask6V20.txt";





            Console.WriteLine("данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

        }
    }
}