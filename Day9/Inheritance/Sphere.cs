public class Sphere:Circle
{
    public Sphere(double radius)
    :base(radius)
    {}
    public override double GetArea()=>4*Math.PI*radius*radius;
}