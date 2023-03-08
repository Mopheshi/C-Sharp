public class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent called...");
    }

    public Parent(int num)
    {
        Console.WriteLine(String.Format("\tParent called: {0}...\n", num));
    }
}
