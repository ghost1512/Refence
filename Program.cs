using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 1;
        int c = 20;
        Console.WriteLine($"Gia tri ban dau: {a} {b} {c}");
        Mul(ref a, ref b);
        Exam(out c);
        Console.WriteLine($"Gia tri sau khi thay doi: {a} {b} {c}");
    }
    static void Mul(ref int a, ref int b)
    {
        a = 20 * 2;
        b = 20 * 4;
    }
    static void Exam(out int c)
    {
        c = 100;
    }
}