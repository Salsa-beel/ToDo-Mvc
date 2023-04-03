using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvc_Project1.Models;

namespace Mvc_Project1.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}


    MyTaskContext db; // lazm a3mel objkect mn el context 3ashan a3raf ast5dem el database

    public HomeController(MyTaskContext context) // lazm a3mel inject 3an tare2 el constructor
    {

        db = context;
     }


    public IActionResult Index()
    
    {
        var result = db.Categories.ToList(); // tolist bageb mnha el data el gwa el categories
        return View( result);
    }



    //========Contact=========================================


    public IActionResult Contact() // el data el gaya gaya L table ContactUS

    {
        return View();
    }



    [HttpPost] 
    public IActionResult SaveContact(ContactUs model) // el data el gaya gaya L table ContactUS

    {

        db.Contacts.Add(model);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    //===========Show Messages==================================

    public IActionResult Messages() // el data el gaya gaya L table ContactUS

    {

        var result = db.Contacts.ToList(); // tolist bageb mnha el data el gwa el categories
        return View(result);
    }

    //==============================================================

    public IActionResult Tasks(int id)
    {

        Category c = db.Categories.Find(id);

        //ViewBag.Tas = c.Name;
        ViewData["Tas"] = c.Name; 

        var result = db.MyTask.Where(y => y.CategoryId == id).OrderByDescending(x=>x.Date).ToList();

        return View(result);
    }




    //==============================================================

    public IActionResult DeleteTasks(int id)

    {
        var Tasks = db.MyTask.Find(id);
        db.MyTask.Remove(Tasks);
        db.SaveChanges();
        return RedirectToAction("Index");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

