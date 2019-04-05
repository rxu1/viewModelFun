using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("users")]
    public IActionResult UserDetail()
    {
      User raymond = new User("Raymond", "Xu");
      User harry = new User("Harry", "Potter");
      User hermione = new User("Hermione", "Granger");
      List<User> user = new List<User>(); 
      {
        user.Add(raymond);
        user.Add(harry);
        user.Add(hermione);
      }
        // Here we pass this instance to our View
      return View("index", user);
    }

    [HttpGet("user/details")]
    public IActionResult SpecificUser()
    {
      User raymond = new User("Raymond", "Xu");
      return View("UserDetail", raymond);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
      int[] arr = new int[] {2, 4, 6, 8, 10};
      return View("Numbers", arr);
    }

    [HttpGet("messages")]
    public IActionResult Messages()
    {
      string message = "Please work messages!!!!!!";
      return View("Messages", message);
    }
  }
}
