class Rectangle:IShape
{
    public Rectangle(double l,double b)
    {
        length=l;
        breadth=b;
    }
    double length;
    double breadth;

    public double GetArea() => return length*breadth;
    
    public double GetPerimeter() => returl 2*(length*breadth);
}