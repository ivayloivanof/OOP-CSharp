using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

class Person
{
    private int age;
    private string name;
    private string email;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("The name can not be null. ");
            }
            this.name = value;
            value.Trim();
            if(value==""&&value==" ")
            {
                throw new ArgumentException("The name can not be empty");
            }
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("The age is not valis or is out of range");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null)
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email");
                }
            }
            this.email = value;
        }
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(string.Format("Name: {0}\nAge: {1}\nEmail: {2}", this.Name, this.Age,this.Email));
        return result.ToString();
    }
}

