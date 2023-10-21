class Program
{
static void NumberResult(string[] args)
{
    Console.Write("Enter radius: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Second number: ");
    int b = Int32.Parse(Console.ReadLine()!);
    Console.Write("Third number: ");
    int c = Int32.Parse(Console.ReadLine()!);
    Console.WriteLine("Result is {0}", a + b + c);
}
static void Int(string[] args)
{
    Console.Write("Enter radius: ");
    int r = Int32.Parse(Console.ReadLine()!);
    Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);
}
static void HexNum(string[] args)
{
    int hexNum = 2015;
    Console.WriteLine("|0x{0,-8:X|", hexNum);
    double fractNum = -1.856;
    Console.WriteLine("|0,-10:f2}|", fractNum);
}
static void Counter(string[] args)
{
    int counter = 0;
    
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine()!);
    
    for (int i = a; i <= b; i++)
    {
        if (i % 5 == 0) counter++;
    }
    
    Console.WriteLine("{0} numbers found.", counter);
}
static void Parse(string[] args)
{    
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine()!);
    
    Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b));
}
static void Count(string[] args)
{    
    int sum = 0;
    
    Console.Write("Enter numbers count: ");
    int length = Int32.Parse(Console.ReadLine()!);
    
    for (int i = 0; i < length; i++)
    {
        Console.Write("Enter {0} number: ", i + 1);
        sum += Int32.Parse(Console.ReadLine()!);
    }
    
    Console.WriteLine("Sum of all numbers is {0}.", sum);
}
static void SumLenght(string[] args)
{    
    int sum = 0;
    
    Console.Write("Enter number: ", sum);
    int length = Int32.Parse(Console.ReadLine()!);
    
    for (int i = 1; i <= length; i++)
    {
        Console.WriteLine(i);
    }    
}
static void numResult(string[] args)
{    
    int num1 = 0;
    int num2 = 1;
    int sum = 1;
    int count = 0;
    
    Console.WriteLine(num1);
    
    while(count < 100)
    {
        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.WriteLine(num2);
        count++;
    }
}
static void Write(string[] args)
{    
    Console.Write("Enter last number: ");
    int length = Int32.Parse(Console.ReadLine()!);
    double sum = 1.0;
    
    for (int i = 2; i <= length; i++)
    {
        sum += (1.0 / i);
    }
    
    Console.WriteLine("{0:F3}", sum);
}
}