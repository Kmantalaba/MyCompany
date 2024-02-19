using MyCompany;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Employee employee1 = new Employee(1, "Klent", "Bastatas", "Mantalaba", "Head Manager", 10000);
        employee1.AddAchievements(1,"Best Employee of the Month");

        Employee employee2 = new Employee(2, "Ronald", "Gwapo", "Amancio", "Senior Manager", 60000);
        employee2.AddAchievements(2, "10 Years Awardee");

        employees.Add(employee1);
        employees.Add(employee2);

        var allEmployees = GetAllEmployee(employees);

        foreach (Employee employee in allEmployees)
        {
            Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}, Position: {employee.Position}");
        }

        var x = GetEmployeeById(1);

    }

    private static Employee GetEmployeeById(int v)
    {
       List<Employee> employees = new();
       var getemployee = employees.FirstOrDefault(x => x.Id == v);
        return getemployee;
    }

    private static List<Employee> GetAllEmployee(List<Employee> employees)
    {
        return employees;
    }
}