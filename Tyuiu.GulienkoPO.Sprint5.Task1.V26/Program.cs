using Tyuiu.GulienkoPO.Sprint5.Task1.V26.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int start = -5, end = 5;
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 2.12x^3 + 1.05x^2 + 4.1x * 2, x=2                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(start, end);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан");
            Console.ReadLine();
        }
    }