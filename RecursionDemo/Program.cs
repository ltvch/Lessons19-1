using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190323_RecursDemo
{
    class Program
    {
        const int MAX_REC_LEVEL = 10000;

        static void Main(string[] args)
        {
            #region Бесконечная рекурсия

            TestFunc(0);

            #endregion            

            long k = GetFactorial(1000);

            Console.WriteLine("k = {0}", k);

            string str = "sdfdsf23424sdfgdf77676 sdfsdf ..////";

            PrintDigits(str);
            PrintDigitsRecurs(str, 0);

            Console.ReadKey();
        }


        public static void TestFunc(int i)
        {
            int k;

            Console.SetCursorPosition(10, 10);
            if (i % 100 == 0)
            {
                Console.WriteLine(i);    
            }

            if (i >= MAX_REC_LEVEL)
            {
                return;
            }

            TestFunc(i + 1);
        }

        public static void PrintDigits(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(s[i]))
                {
                    Console.Write(s[i]);
                }
            }

            Console.WriteLine();
        }

        public static void PrintDigitsRecurs(string s, int pos)
        {
            if (pos >= s.Length)
            {                
                Console.WriteLine();
                return;
            }

            if (char.IsDigit(s[pos]))
            {
                Console.Write(s[pos]);
            }

            PrintDigitsRecurs(s, pos + 1);
        }

        public int GetSum(int n)
        {
            int result = n;

            for (int i = n - 2; i > 0; i--)
            {
                result += i;
            }

            return result;
        }

        // параметризация 
        //  (i)       n
        // -----    -----
        // (i+1)     n-1
        public static long GetFactorial(int n)
        {
            if (n == 0)
            {
                return 1;    // тривиальный случай (0)! = 1
            }

            return n * GetFactorial(n - 1);
            // декомпозиция
            //   подзадача1: * - умножение
            //   подзадача1: GetFactorial(n - 1) - нахождение факториала меньшего порядка
        }
    }
}
