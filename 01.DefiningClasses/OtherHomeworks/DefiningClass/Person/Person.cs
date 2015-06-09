using System;
class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value != null)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException("This is not valid name");
            }
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value >= 1 && value <= 100)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("This is not valid age.");
            }
        }
    }

    public string Email {
        get { return this.email; }
        set
        {
            if (value == null)  //да го направя с regex за символ @
            {
                this.email = "[unknown email]";
            }
            if (value != null && value.Contains("@"))
            {
                this.email = value;
            }
            
        }
    }
    
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this (name, age, email:null)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return this.name;
    }
}