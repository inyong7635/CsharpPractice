using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Test
    {
        public int value;
        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i < max; i++)
            {
                output += i;
            }

            return output;
        }

        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public void printVar()
        {
            Console.WriteLine(myVar);
        }
    }

}
