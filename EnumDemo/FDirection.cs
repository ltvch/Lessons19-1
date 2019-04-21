using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190309_EnumDemo
{
    [Flags]    // - атрибут, позволяющий использовать всю разрядную сетку как набор битов
    enum FDirection : byte
    {
        NoDiction = 0x00,  // !!! не инициализированное направление
        Left  = 0x01,  // 0000 0001
        Right = 0x02,  // 0000 0010
        Up = 0x04,     // 0000 0100
        Down = 0x08    // 0000 1000
    }
}
