using TDDDbModel;
using TDDLibModel;

namespace TDDLib
{
    public class EmployeesBL : IEmployeesBL
    {
        public IList<IEmployee> AllEmployees { get; set; }
        public EmployeesBL(IList<IEmployee> employees)
        {
            AllEmployees = employees;
        }
        public IList<IEmployee> getAllEmployees()
        {
            return AllEmployees;
        }
        public IEmployee getEmployeesByID(string EmployeeID)
        {
            return AllEmployees.FirstOrDefault(e => e.EmpID == EmployeeID);
        }
    }
}
