using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo((obj as Product).Price);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }

    }
}
