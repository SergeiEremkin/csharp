using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_T5
{
    class Program
    {
        public class Palindrome
        {
            private string value;
            private int Length = 0;
            int[,] table = null;
            char[] s = null;
            public int stringLength = 0;
            public int minCount = 0;
            public Palindrome(string palindromeString)
            {
                value = palindromeString;
                Length = value.Length;
                table = new int[Length, Length];
                s = value.ToCharArray();
                Initialize();
            }

            private void Initialize()
            {
                for (int i = 0; i < Length; i++)
                {
                    table[i, i] = 1;

                    if (i != Length - 1)
                    {
                        if (s[i] == s[i + 1])
                        {
                            table[i, i + 1] = 1;
                        }
                        else
                        {
                            table[i, i + 1] = -1;
                        }
                    }
                }
            }

            public string FindLongestPalindromInString()
            {
                for (int i = 0; i < Length; i++)
                {
                    for (int j = i + 2; j < Length; j++)
                    {

                        table[i, j] = FindAllPalindrome(i, j);
                        if (table[i, j] == 1 && j - i > stringLength)
                        {
                            stringLength = j - i;
                            minCount = i;
                        }
                    }
                }
                return value.Substring(minCount, (stringLength) + 1);

            }

            private int FindAllPalindrome(int p, int q)
            {
                int result = 0;

                if (table[p, q] == 1)
                {
                    result = 1;
                }
                else if (table[p, q] == -1)
                {
                    result = -1;
                }
                else
                {
                    if (s[p] == s[q])
                    {

                        result = FindAllPalindrome(p + 1, q - 1);
                    }
                    else { result = -1; }
                }
                return result;
            }
        }
        static void Main(string[] args)
        {

            //(*) Написать программу, которая находит наибольший палиндром в строке
            //в случае если несколько одного размера вернуть любой

            var word = "aabbggggccc";
            Palindrome obj = new Palindrome(word);
            string value = obj.FindLongestPalindromInString();
           
            Console.WriteLine($"Строка на проверку: {word} \nCамый большой полиндром:{value}");

            Console.ReadLine();
           
        }


    }
}

