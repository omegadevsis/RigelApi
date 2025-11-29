using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}