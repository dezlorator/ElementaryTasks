using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
    class SortedSetOfTriangles : IEnumerable<string>
    {
        #region private

        SortedSet<Triangle> triangleList = new SortedSet<Triangle>();

        #endregion

        public SortedSetOfTriangles()
        {
            triangleList = new SortedSet<Triangle>(new CompareTriangles());
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(Triangle tr in triangleList)
            {
                yield return tr.ToString();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddTriangle(Triangle triangleToAdd)
        {
            triangleList.Add(triangleToAdd);
        }
    }
}
