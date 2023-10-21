class Program
{
    static void ForLoop(string[] args)
{    
    Console.Write("Enter first number: ");
    int length = Int32.Parse(Console.ReadLine()!);
    
    for (int i = 1; i < length; i++)
        Console.WriteLine(i);
}
static void Equivalent(string[] args)
{    
    Console.Write("Enter N: (1<K<N) ");
    int n = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter K: (1<K<N) ");
    int k = Int32.Parse(Console.ReadLine()!);
    
    for (int i = n - 1; i > 0; i--)
    {
        n *= i;
    }
    
    for (int i = k - 1; i > 0; i--)
    {
        k *= i;
    }
    
    n /= k;    
    Console.WriteLine("Result is {0}", n);
}

}