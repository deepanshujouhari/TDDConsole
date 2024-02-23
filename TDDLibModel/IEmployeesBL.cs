using TDDDbModel;

namespace TDDLibModel
{
    public interface IEmployeesBL
    {
        public IList<IEmployee> getAllEmployees();
        public IEmployee getEmployeesByID(string EmployeeID);
    }
}