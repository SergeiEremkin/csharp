using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_T6
{
    class Program
    {
        [Flags]
        public enum WorkDays
        {
            Monday = 0b_1000000,
            Tuesday = 0b_0100000,
            Wednes­day = 0b_0010000,
            Thursday = 0b_0001000,
            Friday = 0b_0000100,
            Saturday = 0b_0000010,
            Sunday = 0b_0000001,
        }
        static void Main(string[] args)
        {
            //(*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели,
            //к примеру, чтобы описать работу какого либо офиса. Явный пример -офис номер 1 работает со вторника до пятницы,
            //офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.

            // Маски расписаний

            WorkDays Shedule1 = WorkDays.Tuesday | WorkDays.Wednesday | WorkDays.Tuesday | WorkDays.Friday;
            WorkDays Shedule2 = WorkDays.Monday | WorkDays.Tuesday | WorkDays.Wednesday | WorkDays.Tuesday | WorkDays.Friday |
                                 WorkDays.Saturday | WorkDays.Sunday;
            WorkDays Shedule3 = WorkDays.Saturday | WorkDays.Sunday;
            //Рабочие дни

            WorkDays allWorkDays = (WorkDays)0b0111111;

            // Те дни, в которые работают офисы

            WorkDays workDaysOffice1 = allWorkDays & Shedule1;
            WorkDays workDaysOffice2 = allWorkDays & Shedule2;
            WorkDays workDaysOffice3 = allWorkDays & Shedule3;

            Console.WriteLine($"\n\nВсе рабочие дни: {allWorkDays}");
            bool isWorkOffice1 = workDaysOffice1 == Shedule1;
            bool isWorkOffice2 = workDaysOffice2 == Shedule2;
            bool isWorkOffice3 = workDaysOffice3 == Shedule3;

            if (isWorkOffice1)

                Console.WriteLine("\n\nРаботает оффис №1");

            if (isWorkOffice2)

                Console.WriteLine("\n\nРаботает оффис №2");

            if (isWorkOffice3)

                Console.WriteLine("\n\nРаботает оффис №3");
            Console.ReadLine();
        }
    }
}
