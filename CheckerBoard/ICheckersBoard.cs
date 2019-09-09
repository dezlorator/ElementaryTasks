using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
    public interface ICheckersBoard
    {
        Cell this[int height, int width]
        {
            get;
            set;
        }
        int GetDimesionLength(int dimension);
        int NumberOfSelectedCheckers(CheckerColor color);
    }
}
