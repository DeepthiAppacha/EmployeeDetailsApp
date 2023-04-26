using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace EmployeeDetailsApp.EmployeeDetails
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HttpClient client;
        private readonly string apiUrl = "https://gorest.co.in/public-api/users/";

        public EmployeeRepository()
        {
            this.client = new HttpClient();
        }

        #region To Get All Employee Data
        /// <summary>
        /// Implements get employee functionality
        /// </summary>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<Employee> GetEmployeeData()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(new Uri(apiUrl));

            if (response.IsSuccessStatusCode)
            {
                var userdata = await response.Content.ReadFromJsonAsync<Employee>();
                return userdata;
            }
            else
            {
                throw new HttpRequestException($"Error Code {response.StatusCode}: Message - {response.ReasonPhrase}");
            }
        }
        #endregion

        #region To Insert or Update Employee
        /// <summary>
        /// To Insert Employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public async Task<bool> InsertEmployeeOrUpdate(string id, string name, string email, string status, string gender, bool isUpdate)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(new
            {
                id,
                name,
                email,
                status,
                gender
            }), Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ApiKey);
            HttpResponseMessage response;
            if (!isUpdate)
            {
                response = await client.PostAsync(apiUrl, jsonContent);
                var responseContent = response.Content.ReadAsStringAsync().Result;
            }
            else
            {

                response = await client.PutAsync(new Uri(apiUrl + id), jsonContent);
                var responseContent = response.Content.ReadAsStringAsync().Result;
            }
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region To Delete Employee
        /// <summary>
        /// To Delete Employee Data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEmployeeData(string id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ApiKey);
            var response = await client.DeleteAsync(new Uri(apiUrl + id));
            var responseContent = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
