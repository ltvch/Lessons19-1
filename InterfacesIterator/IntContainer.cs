using System;
using System.Collections/*.Generic*/;    // for IEnumerable
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190622_InterfacesDemo
{
    class IntContainer: IContainer, IEnumerable
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

        private int[] _items = new int[] { 2, 1, 5, 0, -9, 21, 100, 11 };

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
            //return new ContainerIterator(this);
        }
    }
}
