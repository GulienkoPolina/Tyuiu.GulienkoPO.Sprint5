using Tyuiu.GulienkoPO.Sprint5.Task7.V18.Lib;

namespace Tyuiu.GulienkoPO.Sprint5.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Заменить все буквы н   *");
            Console.WriteLine("* на нн. Полученный результат сохранить в файл                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V18.txt");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V18.txt");
            Console.WriteLine("Данные находятся в файле:" + path);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Находится в файле: " + pathSaveFile);

            Console.ReadKey();

        }
    }
}