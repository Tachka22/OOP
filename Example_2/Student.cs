namespace Example_2;

public class Student : Person
{
    /// <summary>
    /// Учебная группа
    /// </summary>
    public string Group{get;  private set; }
    /// <summary>
    /// Направление обучения
    /// </summary>
    public string Direction{get; private set; }

    public Student(uint id, string firstName, string lastName, uint age, string group, string direction) : base(id,
        firstName, lastName, age)
    {
        Group = group ?? throw new ArgumentNullException(nameof(group));
        Direction = direction ?? throw new ArgumentNullException(nameof(direction));
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine(" Группа: " + Group +" Направление: " + Direction);
    }
}