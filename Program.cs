using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    public class Buyer
    {
       
        public string Name { get; set; }
        public string SecondName { get; set; }
        public long TelephonNumber { get; set; }

        public Buyer(string name , string secondname, long telephonnumber)
          {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Поле name не может быть пустым");
            else if (string.IsNullOrWhiteSpace(secondname))
                throw new ArgumentNullException("Поле secondname не может быть пустым");
            else if (telephonnumber < 10000000000)
                throw new ArgumentOutOfRangeException("Не хватает цифр");
            Name = name;
            SecondName = secondname;
            TelephonNumber = telephonnumber;
          }
    }
        class Program
        {
            static void Main(string[] args)
            {

                 Buyer buyer = new Buyer("Петр", "Иванов", 89993332232);
                 Console.WriteLine($"{buyer.Name} {buyer.SecondName} {buyer.TelephonNumber}");
                 Console.ReadLine();

            }
        }

    
}
