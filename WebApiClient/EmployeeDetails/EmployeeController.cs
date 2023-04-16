namespace EmployeeDetailsApp.EmployeeDetails
{
    public class EmployeeController
    {
        private readonly IEmployeeRepository repo;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            repo = employeeRepository;
        }

        #region To get employee data
        /// <summary>
        /// To get employee data
        /// </summary>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeData()
        {
            return await repo.GetEmployeeData();
        }
        #endregion

        #region Insert or update employee
        /// <summary>
        /// To insert or update employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="gender"></param>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        public async Task<bool> InsertEmployeeOrUpdate(string id, string name, string email, string status, string gender, bool isUpdate)
        {
            return await repo.InsertEmployeeOrUpdate(id, name, email, status, gender, isUpdate);
        }
        #endregion

        #region DeleteEmployee
        /// <summary>
        /// To delete employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEmployeeData(string id)
        {
            return await repo.DeleteEmployeeData(id);
        }
        #endregion
    }
}
