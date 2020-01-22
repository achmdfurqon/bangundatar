using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Square \n2. Rectangle \n3. Circle \n4. Triangle \n5. Rhombus");
            tryagain:
            Console.Write("Choose Shape : ");
            int shape = Convert.ToInt16(Console.ReadLine());
            switch (shape)
            {
                case 1:
                    Console.Write("Side : ");
                    int length = Convert.ToInt16(Console.ReadLine());
                    Square square = new Square();
                    square.length = length;
                    Console.WriteLine("Area of Square : "+ square.Area());
                    Console.WriteLine("Around of Square : "+ square.Around());
                    break;
                case 2:
                    Console.Write("Lenght : ");
                    int p = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Width : ");
                    int l = Convert.ToInt16(Console.ReadLine());
                    Rectangle rectangle = new Rectangle();
                    rectangle.length = p;
                    rectangle.width = l;
                    Console.WriteLine("Area of Rectangle : " + rectangle.Area());
                    Console.WriteLine("Around of Rectangle : ");
                    break;
                case 3:
                    Console.Write("Radius : ");
                    int r = Convert.ToInt16(Console.ReadLine());
                    Circle circle = new Circle();
                    circle.radius = r;
                    Console.WriteLine("Area of Circle : " + circle.Area());
                    Console.WriteLine("Around of Circle : " + circle.Around());
                    break;
                case 4:
                    Console.Write("Side 1 : ");
                    int a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Side 2 : ");
                    int b = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Side 3 : ");
                    int c = Convert.ToInt16(Console.ReadLine());
                    Triangle triangle = new Triangle();
                    triangle.a = a;
                    triangle.b = b;
                    triangle.c = c;
                    Console.WriteLine("Area of Triangle : " + triangle.Area());
                    Console.WriteLine("Around of Triangle : " + triangle.Around());
                    break;
                case 5:
                    Console.Write("Diagonal 1 : ");
                    int d1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Diagonal 2 : ");
                    int d2 = Convert.ToInt16(Console.ReadLine());
                    Rhombus rhombus = new Rhombus();
                    rhombus.d1 = d1;
                    rhombus.d2 = d2;
                    Console.WriteLine("Area of Rhombus : " + rhombus.Area());
                    Console.WriteLine("Around of Rhombus : " + rhombus.Around());
                    break;
                default:
                    Console.WriteLine("There is No Option Number " + shape);
                    goto tryagain;
                    break;
            }
        }
    }
}
