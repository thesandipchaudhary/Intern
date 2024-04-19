class Circle{
    double radius;
 public Circle(double r)
 {
    radius=r;
 }
 public double GetArea()
 {
    return Math.PI*radius*radius;
}
public double GetPerimeter()
{
    return 2*Math.PI*radius;
}
}
 
