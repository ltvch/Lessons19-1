using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190413_ArraysDemo
{
    class Program
    {
        const int DEFAULT_VECTOR_SIZE = 20;

        static Random rnd = new Random();    // генератор случайных чисел (!!! инициализация от текущего времени)

        static void Main(string[] args)
        {
            Print(null);

            int[] vect1;   // null по умолчанию

            int[] vect2;   // null по умолчанию

            vect2 = new int[3] { 2, 4, 5 };    // выделение памяти элементы указанные в списке инициализации

            vect1 = new int[DEFAULT_VECTOR_SIZE];    // выделение памяти под 20 целочисленных элементов массива

            // vect1.Length - кол-во элементов в массиве
            for (int i = vect1.Length - 1; i >= 0; i--)
            {
                vect1[i] = i + 1;
            }

            for (int i = 0; i < vect1.Length; i++)
            {
                Console.WriteLine("vect1[{0}] = {1}", i, vect1[i]);                
            }

            Console.WriteLine("vect1: ");
            Print(vect1);

            Console.WriteLine("vect2: ");
            Print(vect2);

            vect2 = GetRandomVector();

            // System.Threading.Thread.Sleep(1000);

            vect1 = GetRandomVector(10);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("vect1: ");
            Print(vect1);            

            Console.WriteLine("vect2: ");
            Print(vect2);

            //int[] vect2Copy = vect2;    // !!! копирование ссылки
            int[] vect2Copy = (int[])vect2.Clone();    // !!! создание копии массива

            Console.WriteLine("vect2Copy: ");
            Print(vect2Copy);

            vect2Copy[3] = 888;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("vect2: ");
            Print(vect2);

            Console.WriteLine("vect2Copy: ");
            Print(vect2Copy);

            Array.Copy(vect1, 0, vect2, 2, vect1.Length);

            Console.WriteLine("vect2: ");
            Print(vect2);

            //vect2 = SortDemo(vect1, vect2);

            // SearchDemo(vect2);

            Console.ReadKey();
        }

        private static int[] SortDemo(int[] vect1, int[] vect2)
        {
            Array.Sort(vect1);
            Array.Sort(vect2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("vect1: ");
            Print(vect1);

            Array.Reverse(vect2);    // поменять порядок элементов в массиве на обратный

            Console.WriteLine("vect2 (Reverse): ");
            Print(vect2);

            Array.Resize(ref vect2, vect2.Length / 2);
            //Resize(ref vect2, vect2.Length / 2);
            //Resize(ref vect2, vect2.Length * 2);

            Console.WriteLine("vect2 (Resize): ");
            Print(vect2);
            return vect2;
        }

        private static void SearchDemo(int[] vect2)
        {
            //vect2[5] = 0;
            vect2.SetValue(0, 5);

            vect2[3] = 0;

            int pos = Array.IndexOf(vect2, 0);

            Console.WriteLine("pos of 0: {0}", pos);

            int lastPos = Array.LastIndexOf(vect2, 0);

            Console.WriteLine("lastPos of 0: {0}", lastPos);

            Array.Sort(vect2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("vect2 (Sort): ");
            Print(vect2);

            int pos3 = Array.BinarySearch(vect2, 0);

            Console.WriteLine("pos3 of 0: {0}", pos3);
        }

        public static void Print(int[] vect)
        {
            if (vect == null)
            {
                return;
            }

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write("{0}\t", vect[i]);
            }
            Console.WriteLine();
        }

        public static int[] GetRandomVector(int size = DEFAULT_VECTOR_SIZE)
        {
            int[] result = new int[size];

            // Random rnd = new Random();    // генератор случайных чисел (!!! инициализация от текущего времени)

            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = rnd.Next(-1000, 1000);
            }

            return result;
        }

        public static void Resize(ref int[] vect, int newSize)
        { 
            int[] dest = new int[newSize];

            int sizeOfCopy = newSize;
            if (vect.Length < sizeOfCopy)
	        {
                sizeOfCopy = vect.Length;
	        }

            for (int i = 0; i < sizeOfCopy; i++)
            {
                dest[i] = vect[i];
            }

            vect = dest;
        }
    }
}

