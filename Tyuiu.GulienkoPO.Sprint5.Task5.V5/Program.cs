using System.IO;
using Tyuiu.GulienkoPO.Sprint5.Task5.V5.Lib;


namespace Tyuiu.GulienkoPO.Sprint5.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти разницу между максимальным и минимальным целыми числами в файле.  *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений        *");
            Console.WriteLine("* округлить до трёх знаков после запятой                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"""C:\DataSprint5\InPutDataFileTask5V5.txt.txt""";
            Console.WriteLine(" Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Разница между наибольшим и наименьшим значениями: " + res);
            Console.ReadKey();
        }
    }
}