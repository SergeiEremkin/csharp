using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения(application-scope). 
            //    Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках. 
            //    При следующем запуске отобразить эти сведения. Задать приложению версию и описание.

            Console.WriteLine(Properties.Settings.Default.greeting);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Введите ваше имя:");
            Properties.Settings.Default.name= Console.ReadLine();
           
            Console.WriteLine("Введите ваш возраст:");
            Properties.Settings.Default.age =int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите род вашей деятельности");
            Properties.Settings.Default.career = Console.ReadLine();
            Properties.Settings.Default.Save();

            string name = Properties.Settings.Default.name;
            int age = Properties.Settings.Default.age;
            string career = Properties.Settings.Default.career;
            Console.WriteLine();
            Console.WriteLine(name + " " + age + " " + career);

            Console.ReadLine();

        }
    }
}
