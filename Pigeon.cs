public class Pigeon : Bird
{
    public override void Talk()
    {
        Console.WriteLine("Pigeon says: Coo...! coo...!!");
    }

    public override void Fly()
    {
        Console.WriteLine("A pigeon flies away...");
        base.Fly();
    }
}