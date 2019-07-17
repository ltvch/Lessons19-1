using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeviderLib;

namespace _20190713_ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fOk = true;

            do
            {
                try
                {
                    fOk = true;
                    Demo1();
                    //DemoDiv();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    fOk = false;

                }
                catch
                {
                    Console.WriteLine("---=== Test emty catch ===---");
                }
            } while (!fOk);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void Demo1()
        {
            try
            {
                Console.Write("Enter A? : ");

                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter B? : ");

                int b = int.Parse(Console.ReadLine());

                int result = a / b;

                Console.WriteLine("{0} / {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Второй аргумент (B) не может равняться нулю!!!");
                throw;    // Проброс текущего исключения на один уровень выше
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибочный ввод! Аргументы должны являться целыми числами!!!");
                throw;    // Проброс текущего исключения на один уровень выше
            }
            finally
            {
                // Код, который выполняется независимо от появления исключения
                Console.WriteLine("--- ===  finally  === ---");
            }

        }

        private static void DemoTryDiv()
        {
            Console.Write("Enter A? : ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter B? : ");

            int b = int.Parse(Console.ReadLine());

            int result;

            if (Devider.TryDiv(a, b, out result))
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, result);    
            }
            else
            {
                Console.WriteLine("Второй аргумент (B) не может равняться нулю!!!");
            }
        }

        private static void DemoDiv()
        {
            Console.Write("Enter A? : ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter B? : ");

            int b = int.Parse(Console.ReadLine());

            // !!! Отделение алгоритма задачи от обработки "ошибок"
            try
            {
                int result = Devider.Div(a, b);
                Console.WriteLine("{0} / {1} = {2}", a, b, result);
            }
            catch (DeviderException ex)
            {
                Console.WriteLine("Второй аргумент (B) не может равняться нулю!!!");
            }
        }

        private static void DemoUsing()
        {
            // полный аналог работы оператора using
            TestClass obj = new TestClass();
            try
            {
                // work with obj
            }
            finally
            {
                obj.Dispose();
            }
            // более короткий вариант
            using (TestClass obj2 = new TestClass())
            {

            }    // неявный вызов obj2.Dispose();
        }
    }
}
