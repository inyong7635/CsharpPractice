using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Wanted<T>
    {
        public T value;
        public Wanted(T value)
        {
            this.value = value;
        }
    }
}
