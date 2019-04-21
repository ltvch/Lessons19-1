using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20130323_FunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter n : ?");
            //string s = Console.ReadLine();

            //int n;

            //if (int.TryParse(s, out n))
            //{
            //    Console.WriteLine("n = {0}", n);
            //}
            
            int arg1 = 10;

            // Function Call
            // arg1, 12 - список фактических параметров
            int result = GetSum(arg1, 12);

            Console.WriteLine("arg1 = {0}", arg1);

            Console.WriteLine("result = {0}", result);

            int c = 8;
            int e = -8;

            GetSumSub(arg1, 15, out c, out e);

            Console.WriteLine("arg1 = {0}", arg1);

            Console.WriteLine("c = {0}", c);
            Console.WriteLine("e = {0}", e);


            int d = 18;

            int f = 18;

            GetSumSub(arg1, 15, out d, out f);

            Console.WriteLine("arg1 = {0}", arg1);

            Console.WriteLine("d = {0}", d);
            Console.WriteLine("f = {0}", f);

            int countOfNumbers = 0;

            GetCount(1, 2, ref countOfNumbers);
            Console.WriteLine("countOfNumbers = {0}", countOfNumbers);

            GetCount(2, 1, ref countOfNumbers);
            Console.WriteLine("countOfNumbers = {0}", countOfNumbers);

            GetCount(-2, 1, ref countOfNumbers);
            Console.WriteLine("countOfNumbers = {0}", countOfNumbers);

            #region --- ===  Swap demo   === ---

            Console.ForegroundColor = ConsoleColor.Green;

            int a = 3;
            int b = 8;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            //Swap(ref a, ref b);
            Swap(a, b, out a, out b);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            #endregion

            Console.ReadKey();
        }

        // Function definition
        // int - тип возвращаемого значения
        // GetSum - имя функции
        // int a, int b - список формальных параментров
        public static int GetSum(int a, int b)
        {
            int result = a + b;

            a *= 2;

            return result;
        }

        public static void GetSumSub(int a, int b, out int sum, out int sub)
        {
            sum = a + b;

            sub = a - b;

            a *= 2;
        }

        public static void GetCount(int a, int b, ref int count)
        {
            if (a < b)
            {
                count++; 
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Swap(int a, int b, out int aResult, out int bResult)
        {
            aResult = b;
            bResult = a;
        }
    }
}
