using Microsoft.AspNetCore.Mvc;
using WokrforceManagement.Web.Data;
using WokrforceManagement.Web.Models;

namespace WokrforceManagement.Web.Controllers;

public class DepartmentsController : Controller
{
    WorkforceContext db = new WorkforceContext();
    public IActionResult Index()
    {
         var departments = db.Departments.ToList();
        return View(departments);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Department department)
    {
        if (department is null && !ModelState.IsValid)
            return Problem("To be inserted department object is null");

        db.Departments.Add(department);
        db.SaveChanges();
        return RedirectToAction (nameof(Index));
    }
    public IActionResult Edit()
    {
        return View(); 
    }
}
