using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfield4
{
    class Word
    {
        public string Source { get; }
        public string Target { get; set; }
        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
    class Dictionary
    {
        Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
            new Word("red", "красный"),
            new Word("blue", "синий"),
            new Word("green", "зеленый")
            };

        }
        public string this[string source]
        {
            get
            {
                Word word = null;
                foreach (Word w in words)
                {
                    if (w.Source == source)
                    {
                        word = w;
                        break;
                    }
                }
                return word?.Target;
            }
            set
            {
                foreach (Word w in words)
                {
                    if (w.Source == source)
                    {
                        w.Target = value;
                        break;
                    }
                }
            }

        }
        class Instantiator <T>
        {
            public T instance;
            public Instantiator()
            {
                instance = default (T);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                #region Задание 1
                //Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.

                //Console.WriteLine("Введите a: ");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Введите b: ");
                //int b = Convert.ToInt32(Console.ReadLine());
                //int t;
                //int sum = 0;
                //for (int i = a; i <= b; i++)
                //{
                //    t = i % 4;
                //    if (t == 0)
                //    {
                //        sum += i;

                //    }
                //    Console.WriteLine($"сумма целых положительных чисел из промежутка от a до b, кратных четырем = {sum}");
                //}
                #endregion

                #region Задание 2
                //Напишите программу, которая выводит на консоль таблицу умножения

                //for (int i = 1; i <= 9; i++)
                //{
                //    for (int j = 1; j <= 9; j++)
                //    {
                //        Console.Write($"{i * j}\t");
                //    }
                //    Console.WriteLine();
                //}
                #endregion

                #region Задание еще одно
                //Класс Word представляет слово, где свойство Target хранит перевод слова.
                //А класс Dictionary представляет словарь слов и хранит все слова в приватном массиве.
                //Добавьте в класс Dictionary индексатор таким образом, 
                //чтобы с помощью индексатора можно было по слову получить или изменить его перевод.

                //Dictionary dict = new Dictionary();
                //Console.WriteLine($"\n{dict["blue"]}"); 
                //dict["blue"] = "голубой";
                //Console.WriteLine($"\n\t{dict["blue"]}");

                //Вывести на экран все целые числа от 100 до 200, кратные трем.

                //for (int i = 100; i <=200; i++)
                //{
                //    if (i % 3 == 0)

                //    Console.WriteLine(i);
                //}
                #endregion

                #region Задание 3
                //Имеется фрагмент программы в виде оператора цикла с параметром,
                //обеспечивающий вывод на экран «столбиком» квадратного корня из всех целых чисел от a до b(a> b).
                //Оформить этот фрагмент в виде:
                //а) оператора цикла с предусловием;
                //б) оператора цикла с постусловием.
                //Console.WriteLine("Введите a: ");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Введите b: ");
                //int b = Convert.ToInt32(Console.ReadLine());
                //if (a > b) 
                //{
                //    for (int i = b; i <= a; i++)
                //    {
                //        Console.WriteLine( $"\n{ Math.Sqrt(i)}");
                //    }
                //}
                #endregion

                #region Задание 4

                //Дано натуральное число.Определить:
                //а) количество цифр 3 в нем;
                //б) сколько раз в нем встречается последняя цифра;
                //в) количество четных цифр в нем.Составное условие и более одного неполного условного оператора не использовать;
                //г) сумму его цифр, больших пяти;
                //д) произведение его цифр, больших семи;
                //е) сколько раз в нем встречаются цифры 0 и 5(всего).

                //Console.WriteLine("Введите n: ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int c, k, kc, m, last, cnt0, cnt5, prod7, sum5 ;
                //m = n % 10;
                //k = 0;
                //kc = 0;
                //last = 0;
                //cnt0 = 0;
                //cnt5 = 0;
                //prod7 = 1;
                //sum5 = 0;
                //do
                //{
                //    c = n % 10;
                //    if ((n % 10) ==3)
                //    {
                //        k=k+1;
                //    }
                //    if (c==m)
                //    {
                //        last = last + 1;
                //    }
                //    if (n % 2==0)
                //    {
                //        kc = kc + 1;
                //    }
                //    if(n % 10 ==0)
                //    {
                //        cnt0 = cnt0 + 1;
                //    }
                //    if(n % 10==5)
                //    {
                //        cnt5 = cnt5 + 1;
                //    }
                //    if(c>5)
                //    {
                //        sum5 = sum5 + c;
                //    }
                //    if (c>7)
                //    {
                //        prod7 = prod7 * c;
                //    }
                //    n=n/10;
                //}
                //while (n != 0);
                //Console.WriteLine($"\nКоличество цифр 3: {k}");
                //Console.WriteLine($"\nCколько раз в нем встречается последняя цифра: {last}");
                //Console.WriteLine($"\nКоличество четных цифр в нем: {kc}");
                //Console.WriteLine($"\nCумма его цифр, больших пяти: {sum5}");
                //Console.WriteLine($"\nПроизведение его цифр, больших семи: {prod7}");
                //Console.WriteLine($"\nCколько раз в нем встречаются цифры 0 и 5: {cnt0} и {cnt5}");
                #endregion

                #region Задание 5
                //Дано натуральное число.Определить:
                //а) сколько раз в нем встречается цифра а;
                //б) количество его цифр, кратных z(значение z вводится с клавиатуры; z = 2, 3, 4);
                //в) сумму его цифр, больших a(значение a вводится с клавиатуры; 0 <= a <= 8);
                //г) сколько раз в нем встречаются цифры x и y.

                Console.WriteLine("Введите число: ");
                int u = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите числа а, чтобы узнать сколько оно в встреается в вашем числе: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Количество его цифр, кратных z: "); 
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("сколько раз в нем встречаются цифра x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("сколько раз в нем встречаются цифра y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int countA = 0;
                int countZ0 = 0;
                int v;
                int sum8 = 0;
                int countX = 0;
                int countY = 0;
                do
                {
                    v = u % 10;
                  if ((u % 10) == a)
                    {
                        countA = countA + 1;
                    }
                  if (u % z == 0)
                    {
                        countZ0 = countZ0 + 1;
                    }
                    u = u / 10;
                    if (a>=0 && a<=8)
                    {
                        sum8 = sum8 + v;
                    }
                    if ((u % 10) == x)
                    {
                        countX = countX + 1;
                    }
                    if ((u % 10) == y)
                    {
                        countY = countY + 1;
                    }

                }
                while (u != 0);

                Console.WriteLine($"\nСколько раз в нем встречается цифра а: {countA} ");
                Console.WriteLine($"\nКоличество его цифр, кратных z(значение z вводится с клавиатуры; z = 2, 3, 4): {countZ0} ");
                Console.WriteLine($"\nСумму его цифр, больших a(значение a вводится с клавиатуры; 0 <= a <= 8): {sum8} ");
                Console.WriteLine($"\nСколько раз в нем встречаются цифры x и y: {countX} и {countY} ");

                #endregion
                Console.ReadKey();
            }
        }
    }
}