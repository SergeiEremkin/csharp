using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfield2
{
    class Program
    {
        class Bread
        {
            public int Weight { get; set; }
        }
        class Butter
        {
            public int Weight { get; set; }
        }
        class Sandwich
        {
            public int Weight { get; set; }

            public int SandwichWight(Butter butter, Bread bread)
            {
                return butter.Weight + bread.Weight;
            }

        }
         class Celcius
        {
            public double Gradus { get; set; }

            public static implicit operator Fahreheit(Celcius celcius)
                {
                return new Fahreheit { Gradus = 9.0 / 5 * celcius.Gradus + 32 };    
                }
            public static implicit operator Celcius(Fahreheit fahreheit)
            {
                return new Celcius { Gradus = 5.0 / 9 * fahreheit.Gradus - 32 };
            }
         }
         class Fahreheit
        {
            public double Gradus { get; set; }
        }

        class Dollar
        {
            public decimal Sum { get; set; }

        }
        class Euro
        {
            public decimal Sum { get; set; }

            public static implicit operator Euro(Dollar dollar)
            {
                return new Euro { Sum = 1.14M * dollar.Sum };
            }
            public static implicit operator Dollar(Euro euro)
            {
                return new Dollar { Sum = euro.Sum / 1.14M };
            }

        }
        static void Main(string[] args)
        {
            Bread bread = new Bread { Weight = 50 };
            Butter butter = new Butter { Weight = 30 };
            Sandwich sandwich = new Sandwich();
            var res = sandwich.SandwichWight(butter, bread);
            Console.WriteLine(res);

            #region Задание 1
            //Определите операторы преобразования от типа Celcius и наоборот.
            //Преобразование температуры по шкале Фаренгейта(Tf) в температуру по шкале Цельсия(Tc): Tc = 5 / 9 * (Tf - 32).
            //Преобразование температуры по шкале Цельсия в температуру по шкале Фаренгейта: Tf = 9 / 5 * Tc + 32.
            #endregion
            Celcius celcius = new Celcius { Gradus = 30 };
            Fahreheit fahreheit = celcius;
            Console.WriteLine(fahreheit.Gradus);
            celcius = fahreheit;
            Console.WriteLine(celcius.Gradus);
            

            #region Задание 2
            Dollar dollar = new Dollar { Sum = 5 };
            Euro euro = dollar;
            Console.WriteLine(euro.Sum);
            dollar = euro;
            Console.WriteLine(dollar.Sum);
            Console.ReadLine();

            #endregion
        }
    }
}
