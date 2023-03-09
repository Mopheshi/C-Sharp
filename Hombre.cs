public class Hombre : Man
{
    public void Speak(string word)
    {
        base.Speak();
        Console.WriteLine(word);
    }
}