using System.ComponentModel.DataAnnotations;

namespace task1
{
    internal class Program
    {
        interface PublicFunc
        {
            double getArea();
            bool isReasonable();
        }
        class Rectangle : PublicFunc
        {
            private double width;
            private double height;
            public Rectangle(double w, double h)
            {
                width = w;
                height = h;
            }
            public double getArea()
            {
                return this.width * this.height;
            }
            public bool isReasonable()
            {
                if (this.width > 0 && this.height > 0)
                {
                    return true;
                }
                return false;
            }
        }
        class Square : PublicFunc
        {
            private double length;
            public Square(double len)
            {
                length = len;
            }
            public double getArea()
            {
                return this.length * this.length;
            }
            public bool isReasonable()
            {
                if (length > 0)
                {
                    return true;
                }
                return false;
            }
        }
        class Triangle : PublicFunc
        {
            private double len1, len2, len3;
            public Triangle(double len1, double len2, double len3)
            {
                this.len1 = len1;
                this.len2 = len2;
                this.len3 = len3;
            }
            public double getArea()
            {
                if (!this.isReasonable())
                {
                    return 0;
                }
                double halfOfPerimeter = (this.len1 + this.len2 + this.len3) / 2;
                return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - this.len1) * (halfOfPerimeter - this.len2) *
                    (halfOfPerimeter - this.len3)); 
            }
            public bool isReasonable()
            {
                if (this.len1 <= 0 || this.len2 <= 0 || this.len3 <= 0)
                {
                    return false;
                }
                double max;
                if (this.len1 >= this.len2 && this.len1 >= this.len3)
                {
                    max = this.len1;
                    if (max >= this.len2 + this.len3)
                    {
                        return false;
                    }
                }
                else if(this.len2 >= this.len1 && this.len2 >= this.len3)
                {
                    max = this.len2;
                    if (max >= this.len1 + this.len3)
                    {
                        return false;
                    }
                }
                else
                {
                    max = this.len3;
                    if (max >= this.len2 + this.len1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4, 5);
            Console.WriteLine(rectangle.getArea());
            Console.WriteLine(rectangle.isReasonable());
            Square square = new Square(5);
            Console.WriteLine(square.getArea());
            Console.WriteLine(square.isReasonable());
            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine(triangle1.getArea());
            Console.WriteLine(triangle1.isReasonable());
            Triangle triangle2 = new Triangle(9, 4, 5);
            Console.WriteLine(triangle2.getArea());
            Console.WriteLine(triangle2.isReasonable());
        }
    }
}
