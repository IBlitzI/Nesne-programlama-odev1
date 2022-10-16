
using Nesne_programlama_odev;

var employee1 = new Employee()
{
    Id = 1,
    Name = "Mehmet Ali",
    Surname = "BASKIN",
    Salary = 15000001
};
var employee2 = new Employee()
{
    Id = 2,
    Name = "Levent",
    Surname = "KIRCA",
    Salary = 15000000
};

var manager = new EmployeeManager();
manager.Add(employee1);
manager.Remove(1);
manager.ListAll();