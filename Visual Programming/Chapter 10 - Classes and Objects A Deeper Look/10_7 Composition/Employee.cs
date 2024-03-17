namespace _10_7_Composition;

public class Employee {
    public string FirstName { get; }
    public string LastName { get; }
    public Date BirthDate { get; }
    public Date HireDate { get; }
    
    public Employee(string firstName, string lastName, Date birthDate, Date hireDate) {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        HireDate = hireDate;
    }
    public override string ToString() => $"{LastName}, {FirstName} " + $"Hired: {HireDate} Birthday: {BirthDate}";
}