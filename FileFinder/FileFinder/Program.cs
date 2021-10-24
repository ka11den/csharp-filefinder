using System;
using System.IO;

namespace FileFinder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите путь к директории:");
            string _catalog = Console.ReadLine();

            Console.WriteLine("Введите название файла:");
            string _file = Console.ReadLine();

            FileFinder(_catalog, _file);
        }
        static void FileFinder(string _catalog, string _file)
        {
            foreach (var _findFile in Directory.EnumerateFiles( _catalog, _file, SearchOption.AllDirectories))
            {
                FileInfo FI;

                try
                {
                    FI = new FileInfo(_findFile);
                    Console.WriteLine("Название файла:\t" + FI.Name + "\n" + "Размер файла:\t" + FI.Length + "\n" + "Путь к файлу:\t" + FI.FullName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Файл не найден!");
                }
            }
        }
    }
}
