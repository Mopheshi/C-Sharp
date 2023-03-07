public class Dog
{
    private string name;
    private string color;
    private int age;

    public void setName(string tag)
    {
        name = tag;
    }

    public void setColor(string dogColor)
    {
        color = dogColor;
    }

    public void setAge(int dogAge)
    {
        age = dogAge;
    }

    public string getName()
    {
        return name;
    }

    public string getColor()
    {
        return color;
    }

    public int getAge()
    {
        return age;
    }

    public string bark()
    {
        return ("\nWoof.!, woof..!!, woof...!!!\n");
    }
}
