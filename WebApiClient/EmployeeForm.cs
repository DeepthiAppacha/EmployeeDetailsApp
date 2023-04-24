using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net.Http;
using EmployeeDetailsApp.EmployeeDetails;

namespace EmployeeDetailsApp
{
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeRepository repo;
        private readonly EmployeeController employeeController;
        public EmployeeForm()
        {
            InitializeComponent();
            repo = new EmployeeRepository();
            employeeController = new EmployeeController(repo);
            GetData();
        }

        #region GetAllEmployee
        /// <summary>
        /// To get all employee details
        /// </summary>
        private async void GetData()
        {
            try
            {
                var employeedata = await employeeController.GetEmployeeData();
                employeeGrid.DataSource = employeedata.Data;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Error Occured: {ex.Message}");
            }
        }
        #endregion

        #region Employee Insert or Employee Update 
        /// <summary>
        /// To insert or update employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EmployeeInsertOrUpdate(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && mailTextBox.Text != "" && statusTextBox.Text != "" && genderTextBox.Text != "")
            {
                try
                {
                    var success = await employeeController.InsertEmployeeOrUpdate(
                   idTextBox.Text,
                   nameTextBox.Text,
                   mailTextBox.Text,
                   statusTextBox.Text,
                   genderTextBox.Text, idTextBox.Text != "");
                    if (success == true)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Please try again!");
                    }
                    GetData();
                    ClearData();
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"HTTP Error Occured: {ex.Message}");
                }
            }
            else if (idTextBox.Text != "")
            {
                MessageBox.Show("Please Select Record to Update!");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        #endregion

        #region To clear data
        /// <summary>
        /// Inorder to clear the data
        /// </summary>
        private void ClearData()
        {
            nameTextBox.Text = "";
            mailTextBox.Text = "";
            statusTextBox.Text = "";
            genderTextBox.Text = "";
            idTextBox.ReadOnly = false;
        }
        #endregion

        #region OnSelection
        /// <summary>
        /// On the selection of row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTextBox.Text = employeeGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTextBox.Text = employeeGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            mailTextBox.Text = employeeGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            genderTextBox.Text = employeeGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            statusTextBox.Text = employeeGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        #endregion

        #region ToDeleteEmployee
        /// <summary>
        /// To Delete the employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DeleteEmployee(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && mailTextBox.Text != "" && statusTextBox.Text != "" && genderTextBox.Text != "")
            {
                try
                {
                    var success = await employeeController.DeleteEmployeeData(idTextBox.Text);
                    if (success == true)
                    {
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please try again!");
                    }
                    GetData();
                    ClearData();
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"HTTP Error Occured: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete!");
            }
        }
        #endregion

    }
}