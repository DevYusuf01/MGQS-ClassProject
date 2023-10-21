//Write an expression that checks whether an integer is odd or even.
class Program
{   
    static void Operators(string[] args)
    {
        int number = 23;
        bool even = number % 2 == 0 ? true : false;
        Console.WriteLine("{0} is even? {1}", number, even);
    }
static void Division(string[] args)
{
    int number = 36;
    bool divisible = number % 35 == 0 ? true : false;
    Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number);
}

static void Seven(string[] args)
{
    int number = 45764;
    bool isSeven = (number / 100) % 10 == 7 ? true : false;
    Console.WriteLine("Third digit of {0} is 7", number);
}

static void Bit(string[] args)
{
    int number = 452;    
    Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);
}

static void Float(string[] args)
{
    float a = 2;
    float b = 3;
    float h = 1;
    Console.WriteLine("S={0}", (a + b) / (2 * h));
}
static void Number(string[] args)
{
    Console.Write("Enter a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("S={0}, P={1}", a * b, (a + b) * 2);
}
static void Weight(string[] args)
{
    Console.WriteLine("Enter weight of a man: ");
    int weight = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);
}
static void Main(string[] args)
{
    Console.Write("Enter x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    bool isInside = (x * x + y * y <= 5) ? true : false;
    Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInside);
}
static void NUmeration(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);
        }

static void BitPosition(string[] args)
{
    int v = 350;
    int p = 350;
    int mask = 1 << p;
    bool isOne = (v & mask) != 0 ? true : false;
    Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, isOne);
}
static void SolvingN(string[] args)
{
    int n = 350;
    int v = 0;
    int p = 3;
    n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
    Console.WriteLine(n);
}
static void PrimeNumber(string[] args)
{
    int number = 72;
    bool isPrime = true;
    if (number > 2)
        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
        {
            if (number % i == 0) isPrime = false;
        }
    Console.WriteLine("{0} is prime?: {1}", number, isPrime);
}

}
