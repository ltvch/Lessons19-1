using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190601_InheritanceDemoII
{
    class A : Base0
    {
        public void f()
        {
            Console.WriteLine("A.f()");
        }

        public /*new virtual*/ override void fVirt()
        {
            Console.WriteLine("A.fVirt()");
        }

        public override string ToString()
        {
            return "class A";
        }
    }

}
