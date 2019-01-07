using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Child : Parent
    {
        public new string variable = "hiding";
        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
    }
}
