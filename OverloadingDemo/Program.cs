using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190518_OverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1 = GetMin(1, 2);

            double m2 = GetMin(1, 2);

            double m3 = GetMin(1.0, 2.0);

            int m4 = GetMin(1, 2, -3);

            int m4_ = GetMin(new int[] { 3, -6, 8 });

            int m4__ = GetMin(1, 2, -3, int.MaxValue);

            int m5 = GetMin(new int[] {3, -6, 8, -90, 77, -100, 123});

            int m6 = GetMin(3, -6, 8, -90, 77, -100, 123, -1000, 23);

            int m7 = GetMin(6);

            int m8 = GetMin();

            int m9 = GetMin(1, 2, -3, -90, 2);

            Console.ReadKey();
        }

        public static int GetMin(int a, int b)
        {
            int result = a;

            if (b < a)
            {
                result = b;
            }

            return result;
        }

        //public static int GetMin(int a, int b, int c)
        //{
        //    int result = GetMin(a, b);

        //    return GetMin(result, c);
        //}

        public static int GetMin(int a, int b, int c, int d = int.MaxValue, int e = int.MaxValue)
        {
            int result1 = GetMin(a, b);
            int result2 = GetMin(c, d);

            return GetMin(GetMin(result1, result2), e);
        }

        public static int GetMin(params int[] items)
        {
            if (items.Length == 0)
            {
                Console.WriteLine("Error!!!");
                return int.MaxValue;
            }

            int result = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] < result)
                {
                    result = items[i];
                }
            }

            return result;
        }

        public static int GetMin(int def = -1, params int[] items)
        {
            int result = def;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < result)
                {
                    result = items[i];
                }
            }

            return result;
        }

        public static double GetMin(double a, double b)
        {
            double result = a;

            if (b < a)
            {
                result = b;
            }

            return result;
        }
    }
}
