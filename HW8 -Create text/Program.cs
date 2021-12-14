using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
 * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/
class Program
{
    static void Main(string[] args)
    {
                int[] numbers = new int[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = random.Next(0, 100);
        }
        string Path = "RND_numbers.txt";
        StreamWriter TxtFile = new StreamWriter(Path, false);
        Array.ForEach(numbers, Console.WriteLine);
        TxtFile.Close();
        /* StreamWriter TxtFile = new StreamWriter(Path, false);
         TxtFile.WriteLine(numbers[]);
         TxtFile.Close();*/

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}