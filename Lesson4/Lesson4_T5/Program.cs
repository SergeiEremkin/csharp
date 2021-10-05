using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_T5
{
    class Program
    {
        class GFG
        {
            
            static float MO2(int a, int b)
            {
                return (float)((a + b) / 2.0);
            }
            
            static float MO3(int a, int b, int c)
            {
                return a + b + c - Math.Max(a, Math.Max(b, c)) -
                  Math.Min(a, Math.Min(b, c));
            }
            static float MO4(int a, int b, int c, int d)
            {
                int Max = Math.Max(a, Math.Max(b, Math.Max(c, d)));
                int Min = Math.Min(a, Math.Min(b, Math.Min(c, d)));
                return (float)((a + b + c + d - Max - Min) / 2.0);
            }
            
            static float medianSingle(int[] arr, int n)
            {
                if (n == 0)
                    return -1;
                if (n % 2 == 0)
                    return (float)((double)(arr[n / 2] +
                                              arr[n / 2 - 1]) / 2);
                return arr[n / 2];
            }

            static int[] copyOfRange(int[] src, int start, int end)
            {
                int len = end - start;
                int[] dest = new int[len];
                Array.Copy(src, start, dest, 0, len);
                return dest;
            }
            
            static float findMedianUtil(int[] A, int N,
                                        int[] B, int M)
            {
                
                if (N == 0)
                    return medianSingle(B, M);

               
                if (N == 1)
                {

                   
                    if (M == 1)
                        return MO2(A[0], B[0]);

                    
                    if (M % 2 == 1)
                        return MO2(B[M / 2], (int)MO3(A[0],
                                    B[M / 2 - 1], B[M / 2 + 1]));

                    
                    return MO3(B[M / 2], B[M / 2 - 1], A[0]);
                }

                
                else if (N == 2)
                {

                    if (M == 2)
                        return MO4(A[0], A[1], B[0], B[1]);

                    if (M % 2 == 1)
                        return MO3(B[M / 2], Math.Max(A[0], B[M / 2 - 1]),
                                   Math.Min(A[1], B[M / 2 + 1]));

                    return MO4(B[M / 2], B[M / 2 - 1],
                               Math.Max(A[0], B[M / 2 - 2]),
                               Math.Min(A[1], B[M / 2 + 1]));
                }

                int idxA = (N - 1) / 2;
                int idxB = (M - 1) / 2;

                if (A[idxA] <= B[idxB])
                    return findMedianUtil(copyOfRange(A, idxA, A.Length),
                                          N / 2 + 1, B, M - idxA);
              
                return findMedianUtil(A, N / 2 + 1,
                                      copyOfRange(B, idxB, B.Length), M - idxA);
            }

            static float findMedian(int[] A, int N, int[] B, int M)
            {
                if (N > M)
                    return findMedianUtil(B, M, A, N);

                return findMedianUtil(A, N, B, M);
            }
            static void Main(string[] args)
            {
                // Найти число, которое является медианой 2 -х массивов

                var A = new[] { 1, 2, 6, 8, 9 };
                var B = new[] { 3, 4, 7 };
                int N = A.Length;
                int M = B.Length;

                Console.WriteLine(findMedian(A, N, B, M));

                Console.ReadLine();
            }
        }
    }
}