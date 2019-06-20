using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemoII
{
    class D : C   
    {
        public new virtual void fVirt()
        {
            Console.WriteLine("D.fVirt()");
        }

        public override string ToString()
        {
            return "class D";
        }
    }
}
