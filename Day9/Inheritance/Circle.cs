public class Circle{
    public double radius;
 public Circle(double r)
 {
    radius=r;
 }
 public virtual double GetArea()
 {
    return Math.PI*radius*radius;
}
public double GetPerimeter()
{
    return 2*Math.PI*radius;
}
}
 
