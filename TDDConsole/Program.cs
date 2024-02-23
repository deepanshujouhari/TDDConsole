using TDDDb;
using TDDDbModel;
using TDDLib;
using TDDLibModel;

public class Program
{
    static void Main(string[] args)
    {
        // In Real world this data came from DB Layer
        var employees = new List<IEmployee>
        {
            new Employee() { EmpID = "101", EmpName = "Sandy Potter", EmpSalary = 60000 },
            new Employee() { EmpID = "102", EmpName = "Jonathan Triss", EmpSalary = 40000 },
            new Employee() { EmpID = "103", EmpName = "Kitty Child", EmpSalary = 60000 },
            new Employee() { EmpID = "104", EmpName = "Harish Saxena", EmpSalary = 100000 },
            new Employee() { EmpID = "105", EmpName = "Lee Lo", EmpSalary = 120000 }
        };


        // This tight couplig can be removed with Unity Constructor Dependency Injection. 
        // For Simplicity keep like this.
        IEmployeesBL empBL = new EmployeesBL(employees); 

        Console.WriteLine("Following are the list of employees");
        foreach (var item in empBL.getAllEmployees())
        {
            Console.WriteLine(item.EmpName);
        }
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Get Employee ID 106");
        Console.WriteLine(empBL.getEmployeesByID("106")?.EmpName ?? "Employee ID Not Found");

        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Get Employee ID 103");
        Console.WriteLine(empBL.getEmployeesByID("103").EmpName);

        Console.ReadLine();
    }
}