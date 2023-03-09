public class Chicken : Bird
{
    public override void Talk()
    {
        Console.WriteLine("Chicken says: Cluck...! cluck...!!");
    }

    public override void Fly()
    {
        Console.WriteLine("I am a chicken - I can't fly...");
        base.Fly();
    }
}