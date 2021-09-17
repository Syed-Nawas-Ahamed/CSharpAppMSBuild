using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Arith : IArith
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
