using System;
class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (this.age >= 1 && this.age <= 100)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("Not valid age.");
            }
        }
    }

    public Person(string name, int age)
    {
       
    }

    public override string ToString()
    {
        return base.ToString();
    }
}