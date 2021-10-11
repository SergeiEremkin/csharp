using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
          public static void EndProcess()
        {
            Process[] allProcess = Process.GetProcesses();
            try
            {


                for (int i = 0; i < allProcess.Length; i++)
                {
                    Console.WriteLine($"{allProcess[i].ProcessName}    {allProcess[i].Id}");
                }

                Console.WriteLine("\nЕсли хотите завершить процесс по имени нажмите 1, если по ID нажмите 2 ");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Введитя имя процесса, чтобы завершить его");
                        string chosen = Console.ReadLine();
                        foreach (Process p in Process.GetProcessesByName(chosen))
                        {
                            p.Kill();
                            Console.WriteLine($"Процесс {p} завершен");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите ID процесса чтобы завершить его");
                        int chosenId = Convert.ToInt32(Console.ReadLine());
                        Process byId = Process.GetProcessById(chosenId);
                        byId.Kill();
                        Console.WriteLine($"Процесс {byId} завершен");
                        break;
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Некоректный ввод");

            }
        }


        static void Main(string[] args)
        {
            //Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс.
            //Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
            //В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.


            EndProcess();
           
            Console.ReadLine();
        }
        }
}

  


