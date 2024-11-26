using Tyuiu.GulienkoPO.Sprint5.Task4.V2.Lib;
namespace Tyuiu.GulienkoPO.Sprint5.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение из   *");
            Console.WriteLine("* файла и подставить вместо Х в формулу.                                  *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            string path = @"C:\DataSprint5\InPutDataFileTask4V2.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные находятся в файле: " + path);
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}