internal class Variables
{
    //enum Days { Sat, Sun, Mon, Tue, Wed, Thur, Fri }

    private static void Main(string[] args)
    {


        //Console.Title = "Variables";

        //char letter = 'a';
        //int number = 100;
        //double pi = 3.14159;
        //float body = 98.6f;
        //decimal sum = 1000.00m;
        //bool flag = false;
        //string text = "c# is fun";

        //Console.WriteLine("char:\t" + letter);
        //Console.WriteLine("int:\t" + number);
        //Console.WriteLine("double:\t" + pi);
        //Console.WriteLine("float:\t" + body);
        //Console.WriteLine("decimal:\t" + sum);
        //Console.WriteLine("bool:\t" + flag);
        //Console.WriteLine("string:\t" + text);
        //Console.ReadKey();



        //Console.Title = "Input";

        //Console.Write("Please type your name: ");

        //String name = Console.ReadLine();

        //Console.WriteLine("Welcome " + name + "!");
        //Console.ReadKey();



        //Console.Title = "Conversion";

        //Console.Write("Please type a number: ");

        //double num = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Type another number: ");

        //double sum = num + Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Total = " + sum);
        //Console.ReadKey();



        //Console.Title = "Arrays";

        //string[] cars = new string[3] { "BMW", "Ford", "Opel" };

        //int[,] coordinates = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        //Console.WriteLine("Second car: " + cars[1]);
        //Console.WriteLine("X1,Y1: " + coordinates[0, 0]);
        //Console.WriteLine("X2,Y3: " + coordinates[1, 2]);
        //Console.ReadKey();



        //Console.Title = "Casts";

        //double num = 10.5;
        //int integer = 2;
        //num = num + integer;

        //Console.WriteLine("Implicit cast: " + num);

        //num = (double)7 / integer;

        //Console.WriteLine("Explicit cast: " + num);

        //char letter = (char)65;

        //Console.WriteLine("Cast integer: " + letter);

        //int ascii = (int)'A';

        //Console.WriteLine("Cast letter: " + ascii);
        //Console.WriteLine("Datatyoe if num variable is : " + num.GetType().ToString());
        //Console.ReadKey();



        //Console.Title = "Constant";

        //const double pi = 3.14159265358979;
        //var daysType = typeof(Days);

        //Console.WriteLine("Pi Type: " + pi.GetType());
        //Console.WriteLine("Circumference: " + (pi * 3));
        //Console.WriteLine("\nFirst Name: " + Days.Sat);
        //Console.WriteLine("1st Index: " + (int)Days.Sat);

        //string name = Enum.GetName(daysType, 1);

        //Console.WriteLine("\n2nd Index: " + name);

        //bool flag = Enum.IsDefined(daysType, "Mon");

        //Console.WriteLine("Contains 'Mon'?: " + flag);
        //Console.ReadKey();



        //Console.Title = "Arithmetic";

        //int a = 8; int b = 4;

        //Console.WriteLine("Addition:\t: " + (a + b));
        //Console.WriteLine("Subtraction:\t: " + (a - b));
        //Console.WriteLine("Multiplication:\t: " + (a * b));
        //Console.WriteLine("Division:\t: " + (a / b));
        //Console.WriteLine("Modulus:\t: " + (a % b));
        //Console.WriteLine("\nPostfix:\t: " + (a++));
        //Console.WriteLine("Postfix Result:\t: " + a);
        //Console.WriteLine("\nPrefix:\t\t: " + (++b));
        //Console.WriteLine("Prefix Result:\t: " + b);
        //Console.ReadKey();



        //Console.Title = "Assign";

        //int a, b;

        //Console.Write("Assign Values: ");
        //Console.Write("\t\t a = " + (a = 8));
        //Console.WriteLine("\t b = " + (b = 4));

        //Console.Write("\n\nAdd and Assign ");
        //Console.Write("\t\t :a += b(8 += 4)\t a = " + (a += b));
        //Console.Write("\n\nSubtract and Assign ");
        //Console.Write("\t :a -= b(12 -= 4)\t a = " + (a -= b));
        //Console.Write("\n\nMultiply and Assign ");
        //Console.Write("\t :a *= b(8 *= 4)\t a = " + (a *= b));
        //Console.Write("\n\nDivide and Assign ");
        //Console.Write("\t :a /= b(32 /= 4)\t a = " + (a /= b));
        //Console.Write("\n\nModulus and Assign ");
        //Console.WriteLine("\t :a %= b(8 %= 4)\t a = " + (a %= b) + "\n\n");
        //Console.WriteLine("True is = " + Convert.ToInt16(true) + " and False is = " + Convert.ToInt16(false));
        //Console.ReadKey();



        //Console.Title = "Comparison";

        //int nil = 0, num = 0, max = 1;
        //char cap = 'A', low = 'a';

        //Console.Write("Equality:");
        //Console.Write("\t(0 == 0) : " + (nil == num));
        //Console.Write("\n\t\t(A == a) : " + (cap == low));
        //Console.Write("\n\nInequality:");
        //Console.Write("\t(0 != 1) : " + (nil != max));
        //Console.Write("\n\nGreater:");
        //Console.Write("\t(0 > 1) : " + (nil > max));
        //Console.Write("\nLess:");
        //Console.Write("\t\t(0 < 1) : " + (nil < max));
        //Console.Write("\n\nGreater/Equal:");
        //Console.Write("\t(0 >= 0) : " + (nil >= num));
        //Console.Write("\nLess/Equal:");
        //Console.Write("\t(1 <= 0) : " + (max <= nil));
        //Console.ReadKey();



        //Console.Title = "Logic";

        //bool yes = true, no = false;

        //Console.WriteLine("AND Logic:");
        //Console.Write("(yes && yes)\t:\t" + (yes && yes));
        //Console.Write("\n(yes && no)\t:\t" + (yes && no));
        //Console.Write("\n(no && no)\t:\t" + (no && no));
        //Console.WriteLine("\n\nOR Logic:");
        //Console.Write("(yes || yes)\t:\t" + (yes || yes));
        //Console.Write("\n(yes || no)\t:\t" + (yes || no));
        //Console.Write("\n(no || no)\t:\t" + (no || no));
        //Console.WriteLine("\n\nNOT Logic:");
        //Console.Write("yes\t\t=\t" + yes);
        //Console.Write("\n!yes\t\t=\t" + !yes);
        //Console.Write("\nno\t\t=\t" + no);
        //Console.Write("\n!no\t\t=\t" + !no);
        //Console.ReadKey();



        //Console.Title = "Condition";

        //int a = 8; int b = 3;

        //string verb = (a != 1) ? "are " : "is ";
        //Console.WriteLine("There " + verb + a + "\n");

        //string parity = (a % 2 != 0) ? "an odd number" : "an even number";
        //Console.WriteLine(a + " is " + parity);

        //parity = (b % 2 != 0) ? "an odd number" : "an even number";
        //Console.WriteLine(b + " is " + parity);

        //int max = (a > b) ? a : b;
        //Console.WriteLine("\nMaximum number between " + a + " and " + b + " is " + max);
        //Console.ReadKey();



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
}