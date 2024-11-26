using System.IO;
using Tyuiu.GulienkoPO.Sprint5.Task5.V5.Lib;


namespace Tyuiu.GulienkoPO.Sprint5.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить     *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после     *");
            Console.WriteLine("* запятой) и вернуть полученный результат на консоль                          *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string path = @"C:\Users\бебе\source\repos\Tyuiu.GulienkoPO.Sprint5\Tyuiu.GulienkoPO.Sprint5.Task5.V5\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V5.txt";

            Console.WriteLine("Данные файла находятся в " + path);
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}