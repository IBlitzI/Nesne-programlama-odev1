namespace Nesne_programlama_odev;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} {LastName}";
    }
}