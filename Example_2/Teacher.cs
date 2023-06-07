namespace Example_2;

public class Teacher : Employees
{
    /// <summary>
    /// Кафедра
    /// </summary>
    public string Department{get;  private set; }
    /// <summary>
    /// Учёная степень
    /// </summary>
    public string AcademicDegree{ get; private set; }

    public Teacher(uint id, string firstName, string lastName, uint age, uint salary, string position, string department, string academicDegree) : base(id, firstName, lastName, age, salary, position)
    {
        Department = department;
        AcademicDegree = academicDegree;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine(" Кафедра: " + Department);
    }
}