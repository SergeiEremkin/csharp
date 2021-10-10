using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

            string filename = "startup.txt";
            DateTime time = DateTime.Now;
            string timeNow= Convert.ToString(time);
            File.WriteAllText(filename, timeNow);
        }
         
        
    }
}
