using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Class1
    {
        double width;
        double length;
        public void acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double getArea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
           
        }
        class excuteRectangle
        {
            static void Main(string[] args)
            {
                Class1 r = new Class1();
                Class2 h = new Class2();
                r.acceptdetails();
                r.getArea();
                r.display();
                h.a();
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

