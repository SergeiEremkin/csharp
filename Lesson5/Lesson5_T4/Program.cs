using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lesson5_T4
{
    class Program
    {
       

        static void DirSearch_ex3(string sDir)
        {
            
            {
               
                Console.WriteLine(sDir);
                

                foreach (string f in Directory.GetFiles(sDir))
                {
                    Console.WriteLine(f);
                    
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch_ex3(d);
                    
                }
            }
            
        }

        static void Main(string[] args)
        {
            //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
            string directory = "directory.txt";
            StreamWriter stream = new StreamWriter(directory,true);
            
            string workDir = @"C:\Users\Сергей\source\repos\Lesson5\";

            Console.WriteLine(Directory.Exists(workDir));

            string[] entries = Directory.GetFileSystemEntries(workDir, ".", SearchOption.AllDirectories);
            
            for (int i = 0; i < entries.Length; i++)
                
            {
                Console.WriteLine(entries[i]);
                stream.WriteLine(entries[i]);
            }
            stream.Close();
            Console.WriteLine();

            DirSearch_ex3(workDir);



            




        }
        }
} 


   
