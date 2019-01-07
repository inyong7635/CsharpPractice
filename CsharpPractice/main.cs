using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class main
    {
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main()
        {
            Test test1 = new Test();

            Test test2 = test1;
            test1.value = 10;
            test2.value = 20;
            Console.WriteLine(test1.value);

            test1.MyProperty = 100;
            test1.printVar();
            Console.WriteLine(test1.MyProperty);

            List<Animal> animals = new List<Animal>() {
                new Dog(), new Cat(), new Dog(), new Cat()
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }
                else
                    ((Cat)item).Meow();

            }
            Console.WriteLine();
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();

            Wanted<string> ws = new Wanted<string>("string");
            Wanted<int> wi = new Wanted<int>(123);
            Wanted<double> wd = new Wanted<double>(50.123);


            Console.WriteLine(ws.value);
            Console.WriteLine(wi.value);
            Console.WriteLine(wd.value);
            Point point = new Point(10, 20);

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);

            //out 키워드 연습
            Console.Write("숫자 입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
                Console.WriteLine("입력한 숫자 : " + output);
            else
                Console.WriteLine("숫자를 입력해 주세요!");
            int x = 1, y = 1, vx = 1, vy = 1;
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표 (" + x + "," + y + ")");

            List<Product> list = new List<Product>() {
                new Product(){ Name = "고구마", Price = 1500},
                new Product(){ Name = "사과", Price = 2400},
                new Product(){ Name = "바나나", Price = 1000},
                new Product(){ Name = "배", Price = 3000},
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
