using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Для полного закрепления понимания простых типов найдите любой чек, 
            либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
            только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) 
            подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
            */

            Console.WriteLine("=====================================");
            string company = "ГУП Волгофарм\nАГФ № 31";
            Console.WriteLine(company);
            Console.WriteLine("------------------------------------------");
            string buyItem = "Аугментин 400МГ + 57МГ/5МЛ 12.6Г ПОРОШ\n216.00";
            Console.WriteLine(buyItem);
            Console.WriteLine("------------------------------------------");
            string BuySum = String.Format("{0:f}", 216.00); ;
            Console.WriteLine($"Итог                          = {BuySum} ");
            uint INN = 003443012297;
            Console.WriteLine($"ИНН                          {INN}");
            string GH = "Будьте здоровы !";
            Console.WriteLine($"\t{GH}");
            Console.ReadLine();
        }
    }
}
