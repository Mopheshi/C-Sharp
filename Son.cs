public class Son : Parent
{
    public Son()
    {
        Console.WriteLine("\tSon called...\n");
    }

    public Son(int num) : base(num)
    {
        Console.WriteLine(String.Format("\tSon called: {0}...", num));
    }
}
