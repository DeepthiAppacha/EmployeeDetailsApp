#region Name-Space Definition
namespace EmployeeDetailsApp.EmployeeDetails
{
    #region Class Definition
    public class Employee
    {
        /// <summary>
        /// Gets or sets the value for code
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Gets or sets the value for users model
        /// </summary>
        public IEnumerable<Users>? Data { get; set; }
    }
    #endregion
}
#endregion
