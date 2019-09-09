using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
    class CompareTriangles : IComparer<Triangle>
    {
        public int Compare(Triangle x, Triangle y)
        {
            if (x.Square > y.Square)
            {
                return -1;
            }
            else if (x.Square < y.Square)
            {
                return 1;
            }
            else
            {
                return x.Name.CompareTo(y.Name);
            }

        }
    }
}
