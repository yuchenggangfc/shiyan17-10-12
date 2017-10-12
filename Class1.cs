using System;
namespace ConsoleApplication1
{
    class Rectangle
    {
        double width;
        double length;
        double area;
        public void acceptdetails()
        {
            length=4.5;
            width=3.5;
        }
        public double getArea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("length: {0}",length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("area: {0}", area);
        }
        class excuteRectangle
        {
            static void mian(string[] args){
                Rectangle r = new Rectangle();
                r.acceptdatails();
                r.getArea();
                r.display();
                Console.WriteLine();
            }
        }
    }
}

