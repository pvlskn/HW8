using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.

class Program
{
    static void Main(string[] args)
    {
        string Path = @"C:\Users";
        if (Directory.Exists(Path))
        {
            Console.WriteLine("Содержимое подкаталогов {0}", Path);
            string[] Cat = Directory.GetDirectories(Path);
            foreach (string c in Cat)
            {
                Directory.GetDirectories(Path);
                Console.WriteLine(c);
                string[] subCat = Directory.GetDirectories(c);
                foreach (string sc in subCat)
                {
                    Directory.GetDirectories(c);
                    Console.WriteLine(sc);
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}