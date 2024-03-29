﻿public class Dog
{
    private string name, color;
    private int age;

    public Dog() { }

    public Dog(string name, string color, int age)
    {
        this.name = name;
        this.color = color;
        this.age = age;
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

    public string bark()
    {
        return ("\nWoof.!, woof..!!, woof...!!!\n");
    }
}
