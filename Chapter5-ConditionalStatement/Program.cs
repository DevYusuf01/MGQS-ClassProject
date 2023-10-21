class Program
{
    static void Num(string[] args)
{    
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine()!);    

    if (a > b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }
    
    Console.WriteLine("First number - {0}, Second number - {1}.", a, b);
}
static void Variation(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine()!);
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine()!);
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine()!);

            if (a > b)
                if (a > c) Console.WriteLine("A is the biggest");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and C are the biggest");
            else if (a < b)
                if (b > c) Console.WriteLine("B is the biggest");
                else if (b < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("B and C are the biggest");
            else if (a == b)
                if (a == c) Console.WriteLine("All are equal");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and B are the biggest");
        }
static void Main(string[] args)
{    
    Console.Write("Enter first number: ");
    int number = Int32.Parse(Console.ReadLine()!);

    switch (number)
    {
        case 0: Console.WriteLine("Nula"); break;
        case 1: Console.WriteLine("Edno"); break;
        case 2: Console.WriteLine("Dve"); break;
        case 3: Console.WriteLine("Tri"); break;
        case 4: Console.WriteLine("Chetiri"); break;
        case 5: Console.WriteLine("Pet"); break;
        case 6: Console.WriteLine("Shest"); break;
        case 7: Console.WriteLine("Sedem"); break;
        case 8: Console.WriteLine("Osem"); break;
        case 9: Console.WriteLine("Devet"); break;
        default: Console.WriteLine("Wrong input"); break;
    }
}
static void NumberClass(string[] args)
{    
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter third number: ");
    int c = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter fourth number: ");
    int d = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter fifth number: ");
    int e = Int32.Parse(Console.ReadLine()!);
    
    if (a < b) a = b;
    if (a < c) a = c;
    if (a < d) a = d;
    if (a < e) a = e;
    
    Console.WriteLine("{0} is the biggest number.", a);
}
       
}