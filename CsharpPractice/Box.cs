using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpProject1
{
    class Box
    {
        private int width;
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("자연수를 입력해 주세요.");
                }
            }
        }
        private int height;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (height > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("자연수를 입력해 주세요.");
                }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Area()
        {
            return this.height * this.width;
        }


    }
}
