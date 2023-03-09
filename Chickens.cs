public sealed class Chickens : Birds
{
    public override void Talk()
    {
        Console.WriteLine("Chicken says: Cluck...! Cluck...!!");
    }

    public override void Fly()
    {
        Console.WriteLine("I am a chicken - I can't fly...\n");
    }
}