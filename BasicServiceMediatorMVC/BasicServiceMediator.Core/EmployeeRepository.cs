using System.Collections.Generic;
using System.Linq;

namespace BasicServiceMediator.Core
{
    public static class EmployeeRepository
    {
        private static List<EmployeeResponse> GetEmployees()
        {
            List<EmployeeResponse> employeeResponses = new List<EmployeeResponse>();

            employeeResponses.Add(new EmployeeResponse()
            {
                EmployeeId = 1,
                EmployeeName = "Syed Ameer",
                DepartmentName = "ITO"
            });


            employeeResponses.Add(new EmployeeResponse()
            {
                EmployeeId = 2,
                EmployeeName = "Shwetha Narayan",
                DepartmentName = "Finance"
            });

            return employeeResponses;
        }
        public static List<EmployeeResponse> GetEmployeeList(int fetchThisManyRecords)
        {
            if (fetchThisManyRecords > 0)
                return GetEmployees().Take(fetchThisManyRecords).ToList();
            else
                return GetEmployees();
        }
        public static EmployeeResponse GetEmployeeById(int id)
        {
            return GetEmployees().Where(e => e.EmployeeId.Equals(id)).FirstOrDefault();
        }
    }
}
