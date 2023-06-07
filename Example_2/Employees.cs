namespace Example_2;

public class Employees : Person
{
    /// <summary>
    /// Зарплата
    /// </summary>
    public  uint Salary { get; private set; }
    /// <summary>
    /// Должность
    /// </summary>
    public string Position { get;  private set; }

    /// <summary>
    /// Конструктор работника заведения
    /// </summary>
    /// <param name="id">id</param>
    /// <param name="firstName">имя</param>
    /// <param name="lastName">фамилия</param>
    /// <param name="age">возраст</param>
    /// <param name="salary">зп</param>
    /// <param name="position">должность</param>
    public Employees(uint id, string firstName, string lastName, uint age, uint salary, string position) : base(id, firstName, lastName, age)
    {
        Salary = salary;
        Position = position;
    }
    /// <summary>
    /// Вывод информации
    /// </summary>
    public new void Print()
    {
        base.Print();
        Console.WriteLine( " Оклад: " + Salary.ToString() + " Должность: " + Position);
    }
}