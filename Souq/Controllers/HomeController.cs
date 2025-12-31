using System.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Souq.Models;

namespace Souq.Controllers;

public class HomeController : Controller
{
    SouqContext db = new SouqContext();


    public IActionResult Index()
    {
        var a = db.Categories.ToList();
        ViewBag.products = db.Products.ToList();
        return View(a);
        
    }
    public IActionResult Detils()
    {

        var a = db.Categories.ToList();
        return View(a);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Cart()
    {
        return View();
    }
    public IActionResult Proudects(int id)
    {
        var a = db.Products.Where(x=> x.CatId == id).ToList();
        return View(a);
    }
    [HttpGet]
    public IActionResult ProudectSerch(string aa)
    {
        var a = db.Products.Where(x => x.Name.Contains(aa)).ToList();
        return View(a);
    }
    [HttpPost]
    public IActionResult sendReview(string Name, string Email, string Subject ,string Description)
    {
        db.Reviews.Add(new Review { Name = Name , Email = Email, Subject= Subject , Description = Description });
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Category()
    {
        var a = db.Categories.ToList();
        return View(a);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
