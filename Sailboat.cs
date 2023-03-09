public partial class Sailboat
{
    private string make, model;

    public Sailboat(string make, string model)
    {
        this.make = make;
        this.model = model;
    }

    /*describe() method is supposed to in Program.cs class, outside the main() method.
    *I don't know why it's not working there, I'd appreciate your help if you know, thanks in advance...**/
    public void describe()
    {
        Console.WriteLine("Sailboat: {0} {1}", make, model);
    }
}