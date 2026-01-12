using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Souq.Models;
using Souq.Models.IdentityModel;
using System.Diagnostics;
using System.Security.Claims;



namespace Souq.Controllers;

public class HomeController : Controller
{
    private readonly SouqContext db;

    public HomeController(SouqContext _db)
    {
        db = _db;
    }

    public IActionResult Index()
    {
        IndexVm a = new IndexVm();
        a.Categories = db.Categories.ToList();
        a.Products = db.Products.ToList();
        a.Reviews = db.Reviews.ToList();
        a.Latestproducts = db.Products.OrderByDescending(x => x.Date).Take(3).ToList();
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
    [Authorize]
    public IActionResult Cart()
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var myCart = db.Carts
                       .Where(c => c.IdentityUserId == identityUserId)
                       .ToList();

        return View(myCart);
    }

    [Authorize]
    public IActionResult AddProductToCart(int id)
    {
        var prise = db.Products.Find(id).Price;

        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // ✅ ID الحقيقي من Identity

        var item = db.Carts.FirstOrDefault(x =>
            x.ProductId == id && x.IdentityUserId == identityUserId);

        if (item != null)
        {
            item.Quantity += 1;
        }
        else
        {
            db.Carts.Add(new Cart
            {
                ProductId = id,
                Quantity = 1,
                IdentityUserId = identityUserId,
                Prise = prise
            });
        }

        db.SaveChanges();
        return RedirectToAction("Cart");
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
                        .Include(p => p.Cat).Include(p=>p.Productimages) 
                        .FirstOrDefault(p => p.Id == id); 

        if (product == null)
            return NotFound(); // أو رسالة مناسبة

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
        var a = db.Categories.ToList();
        return View(a);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
