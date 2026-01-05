using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Souq.Models;
using System.Diagnostics;

namespace Souq.Controllers;

public class HomeController : Controller
{
    SouqContext db = new SouqContext();


    public IActionResult Index()
    {
        IndexVm a = new IndexVm();
        a.Categories = db.Categorys.ToList();
        a.Products = db.Products.ToList();
        a.Reviews = db.Reviews.ToList();
        a.Latestproducts = db.Products.OrderByDescending(x => x.Date).Take(3).ToList();
        return View(a);
        
    }
    public IActionResult Detils()
    {

        var a = db.Categorys.ToList();
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
    [Route("Home/CuranntProduct/{id}")]
    public IActionResult CuranntProduct(int id)
    {
        var product = db.Products
                        .Include(p => p.Cat).Include(p=>p.Productimage) 
                        .FirstOrDefault(p => p.Id == id); 

        if (product == null)
            return NotFound(); // √Ê —”«·… „‰«”»…

        return View(product);
    }

    [HttpGet]
    public IActionResult ProudectSerch(string aa)
    {
        var products = new List<Product>();
        if (string.IsNullOrEmpty(aa)) 
            products = db.Products.ToList();
        else
         products = db.Products.Where(x => x.Name.Contains(aa)).ToList();
        return View(products);
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
        var a = db.Categorys.ToList();
        return View(a);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
