using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TDDDbModel;
using TDDLibModel;
using TDDLib;

namespace TDDLibTest
{

    public class EmployeesBLTests
    {
        [Fact]
        public void GetAllEmployees_Returns_AllEmployees()
        {
            // Arrange
            var employees = new List<IEmployee>
            {
                new Mock<IEmployee>().Object,
                new Mock<IEmployee>().Object,
                new Mock<IEmployee>().Object
            };
            
            var employeesBL = new EmployeesBL(employees);

            // Act
            var result = employeesBL.getAllEmployees();

            // Assert
            Assert.Equal(employees, result);
        }

        [Fact]
        public void GetEmployeesByID_Returns_Employee_With_Given_ID()
        {
            // Arrange
            var employeeID = "123";
            var employeeWithID = new Mock<IEmployee>();
            employeeWithID.Setup(e => e.EmpID).Returns(employeeID);

            var employees = new List<IEmployee>
            {
                new Mock<IEmployee>().Object,
                employeeWithID.Object,
                new Mock<IEmployee>().Object
            };
            var employeesBL = new EmployeesBL(employees);

            // Act
            var result = employeesBL.getEmployeesByID(employeeID);

            // Assert
            Assert.Equal(employeeWithID.Object, result);
        }

        [Fact]
        public void GetEmployeesByID_Returns_Null_If_Employee_Not_Found()
        {
            // Arrange
            var employeeID = "123";
            var employees = new List<IEmployee>
            {
                new Mock<IEmployee>().Object,
                new Mock<IEmployee>().Object,
                new Mock<IEmployee>().Object
            };
            var employeesBL = new EmployeesBL(employees);

            // Act
            var result = employeesBL.getEmployeesByID(employeeID);

            // Assert
            Assert.Null(result);
        }
    }
}
