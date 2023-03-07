public class Cat
{
    private string name, color;
    private int age;

    public Cat()
    {
        name = "Tiger";
        color = "black";
        age = 3;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public void setAge(int age)
    {
        this.age = age;
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

    public string cry()
    {
        return ("\nMeow.!, Meow..!!\n");
    }
}
