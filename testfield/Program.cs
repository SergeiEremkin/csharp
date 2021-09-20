using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfield
{
    
    public class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

       public static State operator + (State state1, State state2 )
        {
            return new State 
            {
                Population = state1.Population + state2.Population,
                Area = state1.Area + state2.Area
            };
        }
        public static bool IsGreater (State state1, State state2)
        {
            return state1.Area > state2.Area;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1

            //В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.Напишите консольную программу,
            //в которую пользователь вводит сумму вклада.
            //Если сумма вклада меньше 100, то начисляется 5 %.Если сумма вклада от 100 до 200, то начисляется 7 %.Если сумма вклада больше 200,
            //то начисляется 10 %.В конце программа должна выводить сумму вклада с начисленными процентами.
            //Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
            #endregion
            Console.WriteLine("\nВведите сумму вклада: ");
            double Deposite = Convert.ToDouble(Console.ReadLine());
            double res;

            if (Deposite <= 100)
            {
                res = Deposite + (Deposite * 5 / 100);
            }
            else if (Deposite > 100 && Deposite <= 200)
            {
                res = Deposite + (Deposite * 7 / 100);
            }
            else
            {
                res = Deposite + (Deposite * 10 / 100);
            }
            Console.WriteLine($"\nСумма вашего вклада: {res}");

            #region Задача 2
            //За каждый месяц банк начисляет к сумме вклада 7% от суммы.
            //Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
            //А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            //Для вычисления суммы с учетом процентов используйте цикл for. 
            //Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
            #endregion

            Console.WriteLine("\n\nВведите сумму вклада: ");
            decimal deposite = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Введите кол-во месяцев: ");
            int MonthCount = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= MonthCount; i++)
            {
                deposite += deposite * 0.07M;
            }
            Console.WriteLine($"\nСумма вклада на {MonthCount} месяцев равна {deposite}");

            #region Задача 2 дополнение

            int m = MonthCount;
            
            while (MonthCount > 0)
            {
                deposite += deposite * 0.07M;
                m--;
            }
            Console.WriteLine($"\nСумма вклада на {MonthCount} месяцев равна {deposite}");

            //Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
            #endregion 
            #region Задача 3
            //С помощью циклов переберите все элементы этого массива и выведите их на консоль в следующем виде:
            #endregion

            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            int x = mas.GetUpperBound(0);
            int y = mas.GetUpperBound(1);
            int z = mas.GetUpperBound(2);

            Console.Write("\n\n\n{");

            for (int i = 0; i <= 0; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= y; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= z; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < z)
                            Console.Write(",");
                    }

                    Console.Write("}");
                    if (j < y)
                        Console.Write(",");
                }
                Console.Write("}");
                if (i < x)
                    Console.Write(",");
            }
            Console.Write("}");

            
           

            #region Задача 4
            State state1 = new State { Population = 30, Area = 40 };
            State state2 = new State { Population = 70, Area = 60 };
            State stateSum = state2 + state1;
            Console.WriteLine($"\n\nНовый город stateSum: Численность населения: {stateSum.Population}, площадь: {stateSum.Area}");
            if (State.IsGreater(state1, state2))
            {
                Console.WriteLine("\n\nstate1 > state2");
            }
            else
                Console.WriteLine("\n\nstate1 < state2");
            #endregion

            #region Задача 5
            Clock clock = new Clock { Hours = 15 };
            int t = (int)clock;
            Clock clock2 = 13;
            Console.WriteLine(clock2);
            clock2 = 20;
            Console.WriteLine(clock2);
            Console.WriteLine(t);
            #endregion

            #region Задание 6
            //Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
            //При этом программа должны запрашивать у пользователя ввод чисел,
            //пока оба вводимых числа не окажутся в диапазоне от 0 до 10.Если введенные числа окажутся больше 10 или меньше 0,
            //то программа должна вывести пользователю о том, что введенные числа недопустимы, 
            //и повторно запросить у пользователя ввод двух чисел.Если введенные числа принадлежат диапазону от 0 до 10, 
            //то программа выводит результат умножения.
            //Для организации ввода чисел используйте бесконечный цикл while и оператор break.
            #endregion
            while (true) 
            {
                Console.Write("\n\nВедите первое число: ");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ведите второе число: ");
                int Number2 = Convert.ToInt32(Console.ReadLine());

                if (Number1 <= 10 && Number1 >= 0 && Number2 <= 10 && Number2 >= 0)
                {
                    int result = Number1 * Number2;
                    Console.Write(result);
                    break;
                }
                else
                {
                    Console.Write("Первое и второе число должно быть в диапазоне от 0 до 10");
                }
            }


            Console.ReadKey();
        }
    }
}