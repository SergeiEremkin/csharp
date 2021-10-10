using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

            Console.WriteLine("Введите произвольный набор чисел: ");
            var numbers = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), numbers);
        }
    }
}
