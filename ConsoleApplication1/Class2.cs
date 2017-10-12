using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class2
    {
        public void a()
        {
            short b;
            double c;
            int d;
            int q = 0, w = 0;
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    q++;
                }
                else
                {
                    w++;
                }
            }
            Console.WriteLine("{0},{1}", q, w);
            b = 10;
            d = 20;
            c = b + d;
            const double pi = 3.14;
            double r;
            Console.WriteLine("enter radius:");
            r = Convert.ToDouble(Console.ReadLine());
            double area = pi * r * r;
            if (b>0){
                Console.WriteLine("dayu 0");

            }
            else
            {
                Console.WriteLine("haha");
            }

            
        Console.WriteLine("{0},{1},{2}",b,d,c);
        Console.WriteLine("hello world");
        Console.WriteLine("area: {0}", area);
        Console.WriteLine("{0}", b<<2);
        Console.ReadKey();
        }
        static T Sum<T>(List<T> nums)
            where T : struct
        {
            T sum = default(T);
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum
        }
    }
}
