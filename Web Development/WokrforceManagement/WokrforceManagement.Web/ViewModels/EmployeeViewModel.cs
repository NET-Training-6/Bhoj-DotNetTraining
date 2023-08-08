using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using WokrforceManagement.Web.Enum;

namespace WokrforceManagement.Web.ViewModels;

public class EmployeeViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter your name"), MinLength(2, ErrorMessage = "At least 2 letters please")]
    public string FirstName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Enter your name"), MinLength(2, ErrorMessage = "At least 2 letters please")]
    public string? MiddleName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Enter your name"), MinLength(2, ErrorMessage = "At least 2 letters please")]
    public string LastName { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;

    [DisplayName("Date Of Birth")]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }

    [DisplayName("Join Date")]
    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }
    public Gender Gender { get; set; }
    public int Department { get; set; }
    public string DepartmentName { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;

    [DisplayName("Your Profile Image")]
    public IFormFile? ProfileImage { get; set; }
    public string ProfileImagePath { get; set; } = string.Empty;
}
