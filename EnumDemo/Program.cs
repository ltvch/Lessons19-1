using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190309_EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Direction direct1 = Direction.NoDiction;

            Console.WriteLine("direct1 : {0} ({1})", direct1, (int)direct1);

            direct1++;

            Console.WriteLine("direct1 : {0} ({1})", direct1, (int)direct1);

            direct1++;

            Console.WriteLine("direct1 : {0} ({1})", direct1, (int)direct1);

            #region Ввод значений перечисления

            Console.Write("[");
            // получение всех значений перечисления
            string[] namesOfDirection = Enum.GetNames(typeof(Direction));
            for (int i = 0; i < namesOfDirection.Length - 1; i++)
            {
                Console.Write("{0}, ", namesOfDirection[i]);
            }
            Console.WriteLine("{0}]", namesOfDirection[namesOfDirection.Length - 1]);

            Console.Write("Choice direction: ? ");

            string sDirect = Console.ReadLine();

            Direction userDirection;

                                                               //               (string) ---> enum
            //if (!(Enum.TryParse(sDirect, out userDirection)    // преобразование sDirect ---> userDirection
            //    && (userDirection > Direction.NoDiction)       //   проверка на допустимые
            //    && (userDirection <= Direction.Down)))         //         значения
            if (!Enum.TryParse(sDirect, out userDirection)      // преобразование sDirect ---> userDirection
                || (userDirection <= Direction.NoDiction)       //   проверка на допустимые
                || (userDirection > Direction.Down))          //         значения
            {
                Console.WriteLine("Wrong direction...");

                Console.ReadKey();
                return;    // завершение работы программы
	        }

            switch (userDirection)
            {
                case Direction.Left:
                    Console.WriteLine("Лево");
                    break;
                case Direction.Right:
                    Console.WriteLine("Право");
                    break;
                case Direction.Up:
                    Console.WriteLine("Верх");
                    break;
                case Direction.Down:
                    Console.WriteLine("Низ");
                    break;
                case Direction.NoDiction:
                default:
                    Console.WriteLine("Wrong direction... ({0})", (int)userDirection);
                    break;
            }

            BorderItem lt = BorderItem.LeftTopDoubleCorner;

            Console.WriteLine("Border: {0} {1} ({2:X})", lt, (char)lt, (ushort)lt);

            lt = BorderItem.LeftDownDoubleCorner;

            Console.WriteLine("Border: {0} {1} ({2:X})", lt, (char)lt, (ushort)lt);

            lt++;

            Console.WriteLine("Border: {0} {1} ({2:X})", lt, (char)lt, (ushort)lt);

            #endregion

            #region Битовые перечисления

            // ConsoleKey - стандартное перечисление для всех клавиш клавиатуры

            Console.ForegroundColor = ConsoleColor.Cyan;

            FDirection direct2 = FDirection.Left | FDirection.Up;

            Console.WriteLine("direct2 : {0} ({1})", direct2, (int)direct2);

            if ((direct2 & FDirection.Up) > 0)
            {
                Console.WriteLine("Flag \"Up\" is set");
            }
            else
            {
                Console.WriteLine("Flag \"Up\" is unset");
            }

            if ((direct2 & FDirection.Down) > 0)
            {
                Console.WriteLine("Flag \"Down\" is set");
            }
            else
            {
                Console.WriteLine("Flag \"Down\" is unset");
            }

            if (direct2.HasFlag(FDirection.Left))
            {
                Console.WriteLine("Flag \"Left\" is set");
            }
            else
            {
                Console.WriteLine("Flag \"Left\" is unset");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
