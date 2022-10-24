using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using budget_app.Models;

namespace budget_app.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }

}
