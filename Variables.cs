﻿internal class Variables
{
    //enum Days { Sat, Sun, Mon, Tue, Wed, Thur, Fri }

    private static void Main(string[] args)
    {
        //Console.Title = "Methods";
        //double weight; string num;

        //num = getWeight(out weight);
        //Console.WriteLine(num + "lb = " + lbToKg(weight) + "kg");
        //kgToLb(ref weight);
        //Console.WriteLine(num + "kg = " + weight + "lb");
        //Console.WriteLine(num + "kg = " + weight + "lb");

        //double num, area;

        //Console.WriteLine("Please enter dimension in feet: ");
        //num = Convert.ToDouble(Console.ReadLine());
        //area = computeArea(num);
        //Console.WriteLine("Circle:\t\tArea = " + area + "sq.ft.");
        //area = computeArea(num, num);
        //Console.WriteLine("Square:\t\tArea = " + area + "sq.ft.");
        //area = computeArea(num, num, 'T');
        //Console.WriteLine("Triangle:\tArea = " + area + "sq.ft.");



        Console.Title = "Refactor";
        computeFactorials(1, 10);


        //Console.Title = "";
        //Console.ReadKey();
    }

    static void computeFactorials(int num, int max)
    {
        while (num <= max)
        {
            Console.WriteLine("Factorial of " + num + " is = " + factorial(num));
            num++;
        }
    }

    static int factorial(int x)
    {
        //int result;
        //if (x == 1)
        //{
        //    result = 1;
        //}
        //else
        //{
        //    result = (factorial(x - 1) * x);
        //}
        //return result;
        return (x == 1) ? 1 : (factorial(x - 1) * x);
    }

    static double computeArea(double width, double height, char letter)
    {
        return ((width / 2) * height);
    }

    static double computeArea(double width, double height)
    {
        return (width * height);
    }

    static double computeArea(double width)
    {
        double radius = width / 2;
        return ((radius * radius) * 3.141593);
    }

    static void kgToLb(ref double weight)
    {
        weight = (weight / 0.45359237);
    }

    static double lbToKg(double pounds = 5)
    {
        return (pounds * 0.45359237);
    }

    static string getWeight(out double theWeight)
    {
        theWeight = 10;
        return "10";
    }

    static void bodyTempC()
    {
        Console.WriteLine("Centigrade:\t37ºC");
    }

    static double bodyTempF()
    {
        double temp = 98.6;
        return temp;
    }

    static int bodyTempK()
    {
        int temp = 310;
        return temp;
    }

    static void keyValue(string keyValue)
    {
        Console.Title = keyValue;

        Dictionary<string, string> bookList = new Dictionary<string, string>();

        bookList.Add("Stuart Yarnold", "Arduino");
        bookList.Add("Ndachimya Edward", "Morpheus Softwares");
        bookList.Add("Nick Vandome", "Windows 10");
        bookList.Add("Mike McGrath", "Java");
        bookList.Remove("Ndachimya Edward");
        Console.WriteLine("Popular Titles:");
        foreach (KeyValuePair<string, string> book in bookList)
        {
            Console.WriteLine("Key: " + book.Key + "\tValue: " + book.Value + " in easy steps");
        }
        Console.ReadKey();
    }

    static void forEach(string forEach)
    {
        Console.Title = forEach;

        string[] websites = new string[5] { "Google", "YouTube", "Facebook", "Baidu", "Yahoo!" };

        Console.WriteLine("Popular Websites:");
        int i = 1;
        foreach (string site in websites)
        {
            Console.WriteLine(i + ". " + site);
            i++;
        }
        Console.ReadKey();
    }

    static void whileLoop(string whileLoop)
    {
        Console.Title = whileLoop;

        //Infinite loop...
        int i = 0;
        while (true)
        {
            Console.WriteLine(i);
            i++;
        }

        int[] nums = new int[10];
        while (i < nums.Length)
        {
            nums[i] = i;
            Console.Write("|" + nums[i] + "|");
            i++;
        }
        Console.WriteLine("\n");

        //Definite loop...
        do
        {
            i--;

            if (i == 8)
            {
                Console.Write("Skipped!");
                continue;
            }
            if (i == 3)
            {
                Console.Write("Done!");
                break;
            }
            Console.Write("|" + nums[i] + "|");
        } while (i > 0);
        Console.ReadKey();
    }

    static void forLoop(string forLoop)
    {
        Console.Title = forLoop;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }
        Console.ReadKey();
    }

    static void switches(string switches)
    {
        Console.Title = switches;

        int num = 6;
        string day;

        switch (num)
        {
            case 1:
                day = "Monday";
                break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Wednesday";
                break;
            case 4:
                day = "Thursday";
                break;
            case 5:
                day = "Friday";
                break;
            default:
                day = "Weekend";
                break;
        }
        Console.WriteLine("Day " + num + " : " + day);
        Console.ReadKey();
    }

    static void ifElse(string ifElse)
    {
        Console.Title = ifElse;

        Console.WriteLine("Please enter a number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 5)
        {
            Console.WriteLine("Number is greater than 5.");
        }
        else
        {
            Console.WriteLine("Number is less than or equal to 5.");
        }

        Console.WriteLine("Please type a letter: ");
        char letter = Convert.ToChar(Console.ReadLine());
        if (!letter.Equals(null))
        {
            Console.WriteLine("You typed " + letter);
        }
        else
        {
            Console.WriteLine("You didn't type anything.");
        }

        Console.ReadKey();
    }

    static void precedence(string precedence)
    {
        Console.Title = "Precedence";

        int sum;

        sum = 1 + 4 * 3;
        Console.WriteLine("Default Order: 1 + 4 * 3\t=\t" + sum);

        sum = (1 + 4) * 3;
        Console.WriteLine("Forced Order: (1 + 4) * 3\t=\t" + sum);

        sum = 7 - 4 + 2;
        Console.WriteLine("Default Direction: 7 - 4 + 2\t=\t" + sum);

        sum = 7 - (4 + 2);
        Console.WriteLine("Forced Direction: 7 - (4 + 2)\t=\t" + sum);
        Console.ReadKey();
    }

    static void condition(string condition)
    {
        Console.Title = condition;

        int a = 8; int b = 3;

        string verb = (a != 1) ? "are " : "is ";
        Console.WriteLine("There " + verb + a + "\n");

        string parity = (a % 2 != 0) ? "an odd number" : "an even number";
        Console.WriteLine(a + " is " + parity);

        parity = (b % 2 != 0) ? "an odd number" : "an even number";
        Console.WriteLine(b + " is " + parity);

        int max = (a > b) ? a : b;
        Console.WriteLine("\nMaximum number between " + a + " and " + b + " is " + max);
        Console.ReadKey();
    }

    static void logic(string logic)
    {
        Console.Title = logic;

        bool yes = true, no = false;

        Console.WriteLine("AND Logic:");
        Console.Write("(yes && yes)\t:\t" + (yes && yes));
        Console.Write("\n(yes && no)\t:\t" + (yes && no));
        Console.Write("\n(no && no)\t:\t" + (no && no));
        Console.WriteLine("\n\nOR Logic:");
        Console.Write("(yes || yes)\t:\t" + (yes || yes));
        Console.Write("\n(yes || no)\t:\t" + (yes || no));
        Console.Write("\n(no || no)\t:\t" + (no || no));
        Console.WriteLine("\n\nNOT Logic:");
        Console.Write("yes\t\t=\t" + yes);
        Console.Write("\n!yes\t\t=\t" + !yes);
        Console.Write("\nno\t\t=\t" + no);
        Console.Write("\n!no\t\t=\t" + !no);
        Console.ReadKey();
    }

    static void comparison(string comparison)
    {
        Console.Title = comparison;

        int nil = 0, num = 0, max = 1;
        char cap = 'A', low = 'a';

        Console.Write("Equality:");
        Console.Write("\t(0 == 0) : " + (nil == num));
        Console.Write("\n\t\t(A == a) : " + (cap == low));
        Console.Write("\n\nInequality:");
        Console.Write("\t(0 != 1) : " + (nil != max));
        Console.Write("\n\nGreater:");
        Console.Write("\t(0 > 1) : " + (nil > max));
        Console.Write("\nLess:");
        Console.Write("\t\t(0 < 1) : " + (nil < max));
        Console.Write("\n\nGreater/Equal:");
        Console.Write("\t(0 >= 0) : " + (nil >= num));
        Console.Write("\nLess/Equal:");
        Console.Write("\t(1 <= 0) : " + (max <= nil));
        Console.ReadKey();
    }

    static void assignment(string assign)
    {
        Console.Title = assign;

        int a, b;

        Console.Write("Assign Values: ");
        Console.Write("\t\t a = " + (a = 8));
        Console.WriteLine("\t b = " + (b = 4));

        Console.Write("\n\nAdd and Assign ");
        Console.Write("\t\t :a += b(8 += 4)\t a = " + (a += b));
        Console.Write("\n\nSubtract and Assign ");
        Console.Write("\t :a -= b(12 -= 4)\t a = " + (a -= b));
        Console.Write("\n\nMultiply and Assign ");
        Console.Write("\t :a *= b(8 *= 4)\t a = " + (a *= b));
        Console.Write("\n\nDivide and Assign ");
        Console.Write("\t :a /= b(32 /= 4)\t a = " + (a /= b));
        Console.Write("\n\nModulus and Assign ");
        Console.WriteLine("\t :a %= b(8 %= 4)\t a = " + (a %= b) + "\n\n");
        Console.WriteLine("True is = " + Convert.ToInt16(true) + " and False is = " + Convert.ToInt16(false));
        Console.ReadKey();
    }

    static void arithmetic(string arithmetic)
    {
        Console.Title = "Arithmetic";

        int a = 8; int b = 4;

        Console.WriteLine("Addition:\t: " + (a + b));
        Console.WriteLine("Subtraction:\t: " + (a - b));
        Console.WriteLine("Multiplication:\t: " + (a * b));
        Console.WriteLine("Division:\t: " + (a / b));
        Console.WriteLine("Modulus:\t: " + (a % b));
        Console.WriteLine("\nPostfix:\t: " + (a++));
        Console.WriteLine("Postfix Result:\t: " + a);
        Console.WriteLine("\nPrefix:\t\t: " + (++b));
        Console.WriteLine("Prefix Result:\t: " + b);
        Console.ReadKey();
    }

    //static void constant(string constant)
    //{
    //    Console.Title = constant;

    //    const double pi = 3.14159265358979;
    //    var daysType = typeof(Days);

    //    Console.WriteLine("Pi Type: " + pi.GetType());
    //    Console.WriteLine("Circumference: " + (pi * 3));
    //    Console.WriteLine("\nFirst Name: " + Days.Sat);
    //    Console.WriteLine("1st Index: " + (int)Days.Sat);

    //    string name = Enum.GetName(daysType, 1);

    //    Console.WriteLine("\n2nd Index: " + name);

    //    bool flag = Enum.IsDefined(daysType, "Mon");

    //    Console.WriteLine("Contains 'Mon'?: " + flag);
    //    Console.ReadKey();
    //}

    static void casts(string casts)
    {
        Console.Title = casts;

        double num = 10.5;
        int integer = 2;
        num = num + integer;

        Console.WriteLine("Implicit cast: " + num);

        num = (double)7 / integer;

        Console.WriteLine("Explicit cast: " + num);

        char letter = (char)65;

        Console.WriteLine("Cast integer: " + letter);

        int ascii = (int)'A';

        Console.WriteLine("Cast letter: " + ascii);
        Console.WriteLine("Datatyoe if num variable is : " + num.GetType().ToString());
        Console.ReadKey();
    }

    static void arrays(string arrays)
    {
        Console.Title = arrays;

        string[] cars = new string[3] { "BMW", "Ford", "Opel" };

        int[,] coordinates = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        Console.WriteLine("Second car: " + cars[1]);
        Console.WriteLine("X1,Y1: " + coordinates[0, 0]);
        Console.WriteLine("X2,Y3: " + coordinates[1, 2]);
        Console.ReadKey();
    }

    static void input(string input)
    {
        Console.Title = input;

        Console.Write("Please type your name: ");

        String name = Console.ReadLine();

        Console.WriteLine("Welcome " + name + "!");
        Console.ReadKey();



        Console.Title = "Conversion";

        Console.Write("Please type a number: ");

        double num = Convert.ToDouble(Console.ReadLine());

        Console.Write("Type another number: ");

        double sum = num + Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Total = " + sum);
        Console.ReadKey();
    }

    static void variables(string variables)
    {
        Console.Title = variables;

        char letter = 'a';
        int number = 100;
        double pi = 3.14159;
        float body = 98.6f;
        decimal sum = 1000.00m;
        bool flag = false;
        string text = "c# is fun";

        Console.WriteLine("char:\t" + letter);
        Console.WriteLine("int:\t" + number);
        Console.WriteLine("double:\t" + pi);
        Console.WriteLine("float:\t" + body);
        Console.WriteLine("decimal:\t" + sum);
        Console.WriteLine("bool:\t" + flag);
        Console.WriteLine("string:\t" + text);
        Console.ReadKey();
    }
}