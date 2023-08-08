using WokrforceManagement.Web.Enum;
namespace WokrforceManagement.Web.Models;
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public DateTime Dob { get; set; }
    public DateTime JoinDate { get; set; }
    public Gender Gender { get; set; }
    public string Designation { get; set; } = string.Empty;
    public string ProfileImagePath { get; set; } = string.Empty;

    public int? DepartmentID { get; set; }
    public Department Department { get; set; }
}
