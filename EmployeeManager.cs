namespace Nesne_programlama_odev;

public class EmployeeManager
{
    private List<Employee> _employees;

    public EmployeeManager()
    {
        _employees = new List<Employee>();
    }

    public void Add(Employee employee)
    {
        _employees.Add(employee);
    }

    public void Remove(int id)
    {
        var employee = _employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
            throw new Exception("Belirtilen ID'de bir eleman bulunamadı!");
        _employees.Remove(employee);
    }

    public void ListAll()
    {
        _employees.ForEach(e => Console.WriteLine(e));
    }
}