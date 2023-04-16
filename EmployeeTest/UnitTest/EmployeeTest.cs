using Moq;
using EmployeeDetailsApp.EmployeeDetails;

namespace EmployeeTest.UnitTest
{
    [TestClass]
    public class EmployeeTest
    {
        /// <summary>
        /// To test get employee data
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetEmployeeData()
        {
            // Arrange           
            var expectedEmployee = new Employee();
            expectedEmployee.Code = 201;
            var usersData = new Users();
            var usersList = new List<Users>();
            usersData.Id = 974402;
            usersData.Name = "Satyen Nayar";
            usersData.Email = "satyen@powlowski-barton.info";
            usersData.Gender = "male";
            usersData.Status = "inactive";
            usersList.Add(usersData);
            expectedEmployee.Data = usersList;

            var mockRepo = new Mock<IEmployeeRepository>();
            mockRepo.Setup(x => x.GetEmployeeData()).ReturnsAsync(expectedEmployee);

            var employeeController = new EmployeeController(mockRepo.Object);

            // Act
            var result = await employeeController.GetEmployeeData();

            // Assert
            Assert.AreEqual(expectedEmployee.Code, result.Code);
            Assert.AreEqual(expectedEmployee.Data, result.Data);
        }

        /// <summary>
        /// To test positive flow of create employee method
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task CreateEmployee()
        {
            //Arrange
            bool expectedResult = true;
            var mockRepo = new Mock<IEmployeeRepository>();
            string id = "42";
            string name = "Deepthi";
            string email = "dee@gmail.com";
            string status = "Active";
            string gender = "Female";
            bool isUpdate = false;
            mockRepo.Setup(x => x.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate)).ReturnsAsync(true);
            var employeeController = new EmployeeController(mockRepo.Object);

            //Act            
            var actualResult = await employeeController.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        /// <summary>
        /// To test positive flow of update employee method
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task UpdateEmployee()
        {
            //Arrange
            bool expectedResult = true;
            var mockRepo = new Mock<IEmployeeRepository>();
            string id = "42";
            string name = "Deepthi";
            string email = "dee@gmail.com";
            string status = "Active";
            string gender = "Female";
            bool isUpdate = true;
            mockRepo.Setup(x => x.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate)).ReturnsAsync(true);
            var employeeController = new EmployeeController(mockRepo.Object);

            //Act            
            var actualResult = await employeeController.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        /// <summary>
        /// To test positive flow of delete employee
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task DeleteEmployee()
        {
            //Arrange
            bool expectedResult = true;
            var mockRepo = new Mock<IEmployeeRepository>();
            string id = "42";
            mockRepo.Setup(x => x.DeleteEmployeeData(id)).ReturnsAsync(true);
            var employeeController = new EmployeeController(mockRepo.Object);

            //Act            
            var actualResult = await employeeController.DeleteEmployeeData(id);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
