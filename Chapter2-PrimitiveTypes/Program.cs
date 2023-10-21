using System.ComponentModel.DataAnnotations;

class Program
{
    static void Variables()
    {
        ushort number1 = 52130;
        sbyte number2 = -115;
        uint number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;
        short number6 = 20000;
        byte number7 = 224;
        uint number8 = 970700000;
        sbyte number9 = 112;
        sbyte number10 = -44;
        int number11 = -1000000;
        ushort number12 = 1992;
        long number13 = 123456789123456789;  
        Console.Write("The number's are:", number1, number2, number3, number4, number5, number6, number7, number8, number9, number10, number11, number12, number13);      
    }

static void Primitive()
    {
        double number1 = 34.567839023;
        string number = Convert.ToString(number1);
        float number2 = 12.345f;
        double number3 = 8923.1234857;
        decimal number4 = 3456.091124875956542151256683467m;  
        Console.Write(number, number2, number3, number4);  
    }

static void Master()
    {
        decimal number1 = 5.25745243896m;
        decimal number2 = 9.8544531763m;
        number1 += number2;
        Console.WriteLine(number1.ToString("#.######"));
    }
    static void Main(string[] args)
    {
        int number = 0x100;
        Console.WriteLine("the number is", number);
        
    }
static void Boolean(string[] args)
    {
        bool isMale = true;
        Console.Write(isMale);
    }
 static void Hello(string[] args)
    {
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + " " + str2;
    }

static void WorldConvert(string[] args)
    {
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + " " + str2;
        string str3 = obj.ToString()!;
    }

static void Token(string[] args)
    {
        string str1 = "The \"use\" of quotations causes difficulties.";        
        string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
        Console.Write(str1 += str2);
    }

 static void Construct(string[] args)
    {
        Console.WriteLine("  0        0 ");
        Console.WriteLine("0   0    0   0");
        Console.WriteLine(" 0   0  0   0");
        Console.WriteLine("  0   00   0");
        Console.WriteLine("   0      0 ");
        Console.WriteLine("    0    0  ");
        Console.WriteLine("     0  0   ");
        Console.WriteLine("      00   ");
    }

static void Incredible(string[] args)
    {
        Console.WriteLine("    ©");
        Console.WriteLine("   © ©");
        Console.WriteLine("  ©   ©");
        Console.WriteLine(" ©     ©");
        Console.WriteLine("©©©©©©©©");
    }

static void Name(string[] args)
    {
        string firstName;
        string lastName;
        byte age;
        char gender;
        int id;
        firstName = "Mine";
        lastName = "Yours";
        age = 34;
        gender = 'm'; 
        id = 600;
        Console.WriteLine(firstName, lastName, age, gender, id);
    }

static void Add(string[] args)
    {
        int a = 2;
        int b = 3;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a:{0} b:{1}", a, b);
    } 
}




