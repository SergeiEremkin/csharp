using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson5_T5
{
    /*(*) Список задач(ToDo-list):
             написать приложение для ввода списка задач;
             задачу описать классом ToDo с полями Title и IsDone;
             на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
             если задача выполнена, вывести перед её названием строку «[x]»;
             вывести порядковый номер для каждой задачи;
             при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
             записать актуальный массив задач в файл tasks.json / xml / bin.
             */

    public class ToDo
    {

        public string Title { get; set; }

        public bool IsDone { get; set; }

        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }
        public ToDo()
        {
        }

        public static ToDo[] DeserializeXml(string path)
        {
            string xmlText = File.ReadAllText(path);
            StringReader stringReader = new StringReader(xmlText);
            XmlSerializer serializer = new XmlSerializer(typeof(ToDo[]));
            return (ToDo[])serializer.Deserialize(stringReader);
        }

        public static void SerializeXml (string path, ToDo[] list)
        {
            StringWriter stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(ToDo[]));
            serializer.Serialize(stringWriter, list);
            string xml = stringWriter.ToString();
            File.WriteAllText(path, xml);
        }

        public static void Tasks(ToDo[] tasks)
        {

            int Number = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                Number++;
                {
                    if (tasks[i].IsDone == true)
                    {
                        Console.WriteLine($"[x] {Number}. {tasks[i].Title}");
                    }
                    else
                    {
                        Console.WriteLine($"{Number}. {tasks[i].Title}");
                    }
                }
            }


        }


        public static void Tasks(ToDo[] tasks, int answer)
        {

            int Number = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                Number++;

                if (tasks[i].IsDone == false && answer == Number)
                {
                    Console.WriteLine($"[x] {Number}. {tasks[i].Title}");
                    tasks[i].IsDone = true;
                }
                else if (tasks[i].IsDone == true)
                {
                    Console.WriteLine($"[x] {Number}. {tasks[i].Title}");
                }
                else
                {
                    Console.WriteLine($"{Number}. {tasks[i].Title}");
                }

            }


        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            

            var todos = ToDo.DeserializeXml("tasks.xml");
            ToDo.Tasks(todos);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
              
                Console.WriteLine("\nКакую задачу вы выполнили? Введите порядковый номер задачи:\nВведите '0' чтобы выйти");
                var answer = int.Parse(Console.ReadLine());
                ToDo.Tasks(todos, answer);

                 if (answer == 0)
                    break;
            }


            ToDo.SerializeXml("tasks.xml", todos);

            Console.ReadLine();
        }



    }
}






