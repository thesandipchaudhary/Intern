public class Generics
{
    public void Print<T>(T x)
    {
        Console.WriteLine(x);
    }
    public void test(){
        Print<string>("Generics");
        Print<decimal>(123.333m);
    }

}