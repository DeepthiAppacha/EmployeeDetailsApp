using Moq;
using EmployeeDetailsApp.EmployeeDetails;

namespace EmployeeTest.UnitTest
{
    [TestClass]
    public class EmployeeTest
    {
        private EmployeeController employeeController;
        private Mock<IEmployeeRepository> mockRepo;
        private bool expectedResult;
        private string id;
        private string name;
        private string email;
        private string status;
        private string gender;
        private bool isUpdate;        

        [TestInitialize]
        public void Initialize()
        {
            mockRepo = new Mock<IEmployeeRepository>();
            employeeController = new EmployeeController(mockRepo.Object);
            id = "42";
            name = "Deepthi";
            email = "dee@gmail.com";
            status = "Active";
            gender = "Female";
        }

        /// <summary>
        /// To test get employee data
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetEmployee_ReturnsDataComparision()
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

            mockRepo.Setup(x => x.GetEmployeeData()).ReturnsAsync(expectedEmployee);

            // Act
            var result = await employeeController.GetEmployeeData();

            // Assert
            Assert.AreEqual(expectedEmployee.Code, result.Code);
            Assert.AreEqual(expectedEmployee.Data, result.Data);
        }

        /// <summary>
        /// Test case to check invalid case
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetEmployeeData_InvalidCase()
        {
            mockRepo.Setup(x => x.GetEmployeeData()).ThrowsAsync(new Exception("An error occurred."));

            // Act and Assert
            var ex = await Assert.ThrowsExceptionAsync<Exception>(() => employeeController.GetEmployeeData());
            Assert.AreEqual("An error occurred.", ex.Message);
        }

        /// <summary>
        /// To test positive flow of create employee method
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task CreateEmployee_ReturnsTrue()
        {
            //Arrange
            expectedResult = true;
            isUpdate = false;
            mockRepo.Setup(x => x.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate)).ReturnsAsync(true);

            //Act            
            var actualResult = await employeeController.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        /// <summary>
        /// To test invalid case for create employee
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task CreateEmployee_InvalidCase()
        {
            // Arrange           
            isUpdate = false;
            mockRepo.Setup(x => x.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate)).ThrowsAsync(new Exception("An error occurred."));

            // Act
            var ex = await Assert.ThrowsExceptionAsync<Exception>(() => employeeController.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate));

            // Assert
            Assert.AreEqual("An error occurred.", ex.Message);
        }

        /// <summary>
        /// To test positive flow of update employee method
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task UpdateEmployee_ReturnsTrue()
        {
            //Arrange
            expectedResult = true;
            isUpdate = true;
            mockRepo.Setup(x => x.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate)).ReturnsAsync(true);

            //Act            
            var actualResult = await employeeController.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task UpdateEmployee_InvalidCase()
        {
            // Arrange         
            isUpdate = true;
            mockRepo.Setup(x => x.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate)).ThrowsAsync(new Exception("An error occurred."));

            // Act
            var ex = await Assert.ThrowsExceptionAsync<Exception>(() => employeeController.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate));

            // Assert
            Assert.AreEqual("An error occurred.", ex.Message);
        }

        /// <summary>
        /// To test positive flow of delete employee
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task DeleteEmployee_ReturnsTrue()
        {
            //Arrange
            expectedResult = true;
            mockRepo.Setup(x => x.DeleteEmployeeData(id)).ReturnsAsync(true);

            //Act            
            var actualResult = await employeeController.DeleteEmployeeData(id);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        /// <summary>
        /// To test delete employee for false case
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task DeleteEmployee_ReturnsFalse()
        {
            //Arrange
            expectedResult = false;
            mockRepo.Setup(x => x.DeleteEmployeeData(id)).ReturnsAsync(false);

            //Act            
            var actualResult = await employeeController.DeleteEmployeeData(id);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
