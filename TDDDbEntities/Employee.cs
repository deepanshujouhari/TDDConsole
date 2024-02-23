using TDDDbModel;

namespace TDDDb
{
    public class Employee : IEmployee
    {
        public string EmpName { get; set; }
        public string EmpID { get; set; }
        public int EmpSalary { get; set; }
    }
}
