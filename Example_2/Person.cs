namespace Example_2;

public class Person
{
    /// <summary>
    /// ID
    /// </summary>
    public uint Id { get; private set; }
    
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; private set; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; private set; }
    /// <summary>
    /// Возраст
    /// </summary>
    public uint Age { get; private set; }

    /// <summary>
    /// Конструктор Person
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="firstName">Имя</param>
    /// <param name="lastName">Фамилия</param>
    /// <param name="age">Возраст</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Person(uint id, string firstName, string lastName, uint age)
    {
        Id = id;
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Age = age;
    }
    /// <summary>
    /// Вывести информацию
    /// </summary>
    protected  void Print()
    {
        Console.WriteLine(" Id: "+ Id.ToString() +" Фамилия: " + LastName + " Имя: " + FirstName + " Возраст: " +  Age.ToString());
    }
}