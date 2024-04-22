public class Rectangle:IShape
{
    public Rectangle(double l,double b)
    {
        length=l;
        breadth=b;
    }
    double length;
    double breadth;

    public double GetArea() =>length*breadth;
    
    public double GetPerimeter() => 2*(length*breadth);
}