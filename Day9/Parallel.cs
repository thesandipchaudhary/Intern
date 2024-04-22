using System.Threading;
using System.Threading.Tasks;
public class Parallelll{
    int[] a={123,456,333,555,999};
    public void ProcessNumbers()
{
    foreach(var num in a)
    {
        Dowork(num);
    }
    Parallel.ForEach(a,Dowork);
}
public void Dowork(int num)
{
    Thread.Sleep(1000);
    Console.WriteLine($"Num{num}");
}
}
