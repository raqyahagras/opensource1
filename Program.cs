using System;
namespace Examples;
public class Person
{
    private String _name;
    public string Name
    {
        get { return _name; }

        set
        {
            if (value == null || value == "" || value.Length >= 32)
            {
                throw new Exception("invalid name");
            }
            _name = value;
        }
    }
    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 0 || value > 128)
            {
                throw new Exception("invalid age");
            }
            _age = value;
        }
    }

    public Person(String name, int age)
    {
        if (name == null || name == "" || name.Length >= 32)
        {
            throw new NullReferenceException("invalid name");
        }
        var i = 3 / age;
        if (age <= 0 || age > 128)
        {
            throw new Exception("invalid age");
        }

        Name = name;
        _age = age;
    }
    public string getName() => _name;
    public int getAge() => _age;
    public void setName(String name)
    {
        _name = name;
    }
    public virtual void print()
    {
        Console.WriteLine($"my name is {Name} , my age is {_age}");
    }

}
public class Student : Person
{
    public new String Name;
    public new int Age;
    private int _year;
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            _year = value;
        }
    }
    private float _gpa;
    public float Gpa
    {
        get
        {
            return _gpa;
        }
        set
        {
            _gpa = value;
        }
    }

    public Student(String name, int age, int year, float gpa) : base(name, age)
    {
        if (year < 1 || year > 5)
        {
            throw new Exception("invalid year");
        }
        if (gpa < 0 || gpa > 4)
        {
            throw new Exception("invalid gpa");
        }
        Year = year;
        Gpa = gpa;
    }
    public override void print()
    {
        Console.WriteLine($"My name is {Name},My age is {getAge()} ,and my gpa {Gpa}");
    }
}
public class Database
{
    private int _currentindex;
    public Person[] People = new Person[50];
    public void Addstudent(Student student)
    {
        People[_currentindex++] = student;
    }
    public void Addperson(Person person)
    {
        People[_currentindex++] = person;
    }

    public void Addstaff(Staff staff)
    {
        People[_currentindex++] = staff;
    }
    public void printall()
    {
        foreach (var item in People)
        {
            item?.print();
        }

    }
}
public class Staff : Person
{
    private double _salary;
    public double Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            if (value < 0 || value > 120000)
            {
                throw new Exception("invalid salary");
            }
            _salary = value;
        }
    }
    private int _joinyear;
    public int JoinYear
    {
        get
        {
            return _joinyear;
        }
        set
        {

            _joinyear = value;
        }
    }
    public Staff(String name, int age, double salary, int joinyear) : base(name, age)
    {
        if (salary < 0 || salary > 120000)
        {
            throw new Exception("invalid salary");
        }
        var between = (2022 - Age);
        if (between <= 21)
        {

            throw new Exception("invalid joinyear");
        }
        Salary = salary;
    }
}