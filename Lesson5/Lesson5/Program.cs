using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

            Console.WriteLine("Введите текст:");
            string content = Console.ReadLine();
            string filename = "myTestFile.txt";
            File.WriteAllText(filename, content);

        }
    }
}
