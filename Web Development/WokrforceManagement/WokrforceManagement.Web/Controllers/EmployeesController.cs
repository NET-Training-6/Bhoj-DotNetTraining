using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WokrforceManagement.Web.Data;
using WokrforceManagement.Web.Helpers;
using WokrforceManagement.Web.Mappers;
using WokrforceManagement.Web.Models;
using WokrforceManagement.Web.ViewModels;

namespace WokrforceManagement.Web.Controllers;

public class EmployeesController : Controller
{
    WorkforceContext db = new WorkforceContext();

    [HttpGet]
    public IActionResult Index()
    {      
        List<Employee> employees = db.Employees.ToList();

        List<EmployeeViewModel> employeeViewModels = employees.MapToViewModel();
        return View(employeeViewModels);
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        var employee = db.Employees.Find(id);
        var employeeViewModel = employee.MapToViewModel();
        return View(employeeViewModel);
    }
    [HttpGet]
    public IActionResult Add()
    {
        var departments = db.Departments.ToList();
        var depsSelectlist = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        ViewData["Deps"] = depsSelectlist;
        
        return View();
    }
    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {
        var relativePath = employeeViewModel.ProfileImage?.SaveImage();

        var employee = employeeViewModel.MapToModel();
        
        employee.ProfileImagePath = relativePath;

        db.Employees.Add(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]   
    public IActionResult Edit(int id) 
    {
        var employee = db.Employees.Find(id);
        var employeeViewModel = employee.MapToViewModel();
        return View(employeeViewModel);
    }
    [HttpPost]
    public IActionResult Edit(EmployeeViewModel employeeViewModel)
    {
        var relativePath = employeeViewModel.ProfileImage?.SaveImage();
        employeeViewModel.ProfileImagePath = relativePath;

        var employee = employeeViewModel.MapToModel();

        db.Employees.Update(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        var employeeViewModel = employee.MapToViewModel();
        return View(employeeViewModel);
    }
    [HttpPost]
    public IActionResult Delete(EmployeeViewModel employeeViewModel)
    {
        var employee = employeeViewModel.MapToModel();

        db.Employees.Remove(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}