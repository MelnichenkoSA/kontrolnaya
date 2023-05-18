using System;
using System.Collections.Generic;
using System.Text;

namespace kontrolnaya
{
    class Listik<T>
    {
        public Node<T> first;
        public Node<T> last;
        public Listik()
        {
            first = null;
            last = null;
        }
    }
}
