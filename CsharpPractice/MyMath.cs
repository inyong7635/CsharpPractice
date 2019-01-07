using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpProject1
{
    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0)
                return -input;
            else
                return input;
        }
    }
}
