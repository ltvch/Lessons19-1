using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190622_InterfacesDemo
{
    // 1. Заключение контракта
    interface IContainer
    {
        int Count { get; }
        object this[int index] { get; set; }
    }
}
