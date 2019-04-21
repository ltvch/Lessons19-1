using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190309_EnumDemo
{
    enum BorderItem : ushort
    {
        NoBorder = ' ',
        LeftTopSingleCorner = '┌',
        LeftTopDoubleCorner = '╔',
        LeftDownDoubleCorner = 0x255A
        // ...
    }
}
