using Tyuiu.GulienkoPO.Sprint5.Task0.V13.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 5, результат сохранить   *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить    *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;

            Console.WriteLine("x: " + x);
            string filePath = ds.SaveToFileTextData(x);
            string result = File.ReadAllText(filePath);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат вычисления z: " + result);
        }
    }
}