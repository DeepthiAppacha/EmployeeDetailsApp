using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsApp.EmployeeDetails
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Method to get all employees
        /// </summary>
        /// <returns></returns>
        Task<Employee> GetEmployeeData();

        /// <summary>
        /// Method to insert or update employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="gender"></param>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        Task<bool> InsertEmployeeOrUpdate(string id, string name, string email, string status, string gender, bool isUpdate);

        /// <summary>
        /// Method to delete employee data based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteEmployeeData(string id);

    }
}
