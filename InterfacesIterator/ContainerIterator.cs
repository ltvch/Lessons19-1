using System;
using System.Collections/*.Generic*/;    // for IEnumerator
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190622_InterfacesDemo
{
    struct ContainerIterator : IEnumerator
    {
        public ContainerIterator(IContainer c)
        {
            _c = c;
            _pos = -1;
        }

        public object Current
        {
            get 
            {
                return _c[_pos];    // indexator
            }
        }

        public bool MoveNext()
        {
            ++_pos;

            return _pos < _c.Count;    // prop
        }

        public void Reset()
        {
            _pos = -1;
        }

        private IContainer _c;
        private int _pos;
    }
}
