internal class Variables
{
    enum Days { Sat, Sun, Mon, Tue, Wed, Thur, Fri }

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

        Console.Title = "Constant";

        const double pi = 3.14159265358979;
        var daysType = typeof(Days);
        Console.WriteLine("Pi Type: " + pi.GetType());
        Console.WriteLine("Circumference: " + (pi * 3));
        Console.WriteLine("\nFirst Name: " + Days.Sat);
        Console.WriteLine("\n1ST Index: " + (int)Days.Sat)
        string name = Enum.GetName(daysType, 1);
        Console.WriteLine("\n2nd Index: " + name);
        bool flag = Enum.IsDefined(daysType, "Mon");
        Console.WriteLine("Contains 'Mon'?: " + flag);
        Console.ReadKey();
    }
}