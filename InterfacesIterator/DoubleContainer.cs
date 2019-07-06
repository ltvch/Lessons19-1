using System;
using System.Collections/*.Generic*/;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190622_InterfacesDemo
{
    // 3 (2). interface Implementation
    /*struct*/ class DoubleContainer : IContainer, IEnumerable
    {
        public int Count
        {
            get 
            {
                return _items.Length;
            }
        }

        public object this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private double[] _items = new double[] { 2.1, 5.0, -9.1, 100.01 };


        public IEnumerator GetEnumerator()
        {
            return new ContainerIterator(this);
        }
    }
}
