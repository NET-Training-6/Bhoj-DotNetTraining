using WokrforceManagement.Web.Models;
using WokrforceManagement.Web.ViewModels;

namespace WokrforceManagement.Web.Mappers
{
    public static class EmployeeMapper
    {
        public static Employee MapToModel( this EmployeeViewModel employeeViewModel)
        {
            var employee = new Employee
            {
                Id = employeeViewModel.Id,
                FirstName = employeeViewModel.FirstName,
                MiddleName = employeeViewModel.MiddleName,
                LastName = employeeViewModel.LastName,
                Address = employeeViewModel.Address,
                Gender = employeeViewModel.Gender,
                Contact = employeeViewModel.Contact,
                DepartmentID = employeeViewModel.Department,
                Designation = employeeViewModel.Designation,
                Dob = employeeViewModel.Dob,
                Email = employeeViewModel.Email,
                JoinDate = employeeViewModel.JoinDate,
                ProfileImagePath = employeeViewModel.ProfileImagePath,
            };
            return employee;
        }
        public static EmployeeViewModel MapToViewModel(this Employee employee)
        {
            var employeeViewModel = new EmployeeViewModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                Address = employee.Address,
                DepartmentName = employee.Department?.Name ?? "N/A",
                Designation = employee.Designation,
                Gender = employee.Gender,
                Contact = employee.Contact,
                Dob = employee.Dob,
                Email = employee.Email,
                JoinDate = employee.JoinDate,
                ProfileImagePath = employee.ProfileImagePath,
            };
            return employeeViewModel;
        }
        public static List<EmployeeViewModel> MapToViewModel( this List<Employee> employees)
        {
           var employeeViewModel = employees.Select(emp => MapToViewModel(emp)).ToList();

            return employeeViewModel;
        }
    }
}