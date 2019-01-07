using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class TestClass : IBasics
    {
        public int TestProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int TestInstanceMethod()
        {
            throw new NotImplementedException();
        }
    }
}
