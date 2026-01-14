using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
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
    private readonly UserManager<IdentityUser> _userManager;

    public HomeController(SouqContext _db, UserManager<IdentityUser> userManager)
    {
        db = _db;
        _userManager = userManager;
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

        var myCart = db.Carts.Include(x => x.Product)
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
        var a = db.Products.Where(x => x.CatId == id).ToList();
        return View(a);
    }
    [Route("Home/CuranntProduct/{id}")]
    public IActionResult CuranntProduct(int id)
    {
        var product = db.Products
                        .Include(p => p.Cat).Include(p => p.Productimages)
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
    public IActionResult sendReview(string Name, string Email, string Subject, string Description)
    {
        db.Reviews.Add(new Review { Name = Name, Email = Email, Subject = Subject, Description = Description });
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
    [Authorize]
    public IActionResult IncreaseCart(int id)
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var item = db.Carts.FirstOrDefault(x =>
            x.ProductId == id && x.IdentityUserId == identityUserId);

        if (item != null)
        {
            item.Quantity += 1;
            db.SaveChanges();
        }

        return RedirectToAction("Cart");
    }
    [Authorize]
    public IActionResult Orders()
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var orders = db.Orders
            .Where(x => x.UserNumber == identityUserId)
            .Include(x => x.OrderDetiles)
                .ThenInclude(d => d.Product)
            .ToList();

        return View(orders);
    }


    [Authorize]
    public IActionResult DecreaseCart(int id)
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var item = db.Carts.FirstOrDefault(x =>
            x.ProductId == id && x.IdentityUserId == identityUserId);

        if (item != null)
        {
            item.Quantity -= 1;

          
            if (item.Quantity <= 0)
                db.Carts.Remove(item);

            db.SaveChanges();
        }

        return RedirectToAction("Cart");
    }

    [Authorize]
    public IActionResult RemoveFromCart(int id)
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var item = db.Carts.FirstOrDefault(x =>
            x.ProductId == id && x.IdentityUserId == identityUserId);

        if (item != null)
        {
            db.Carts.Remove(item);
            db.SaveChanges();
        }

        return RedirectToAction("Cart");
    }
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CompleteOrder(string name, string address, string email, string mobile)
    {
        var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        // ✅ اقرأ الكارت بدون Tracking + مع السعر
        var cartItems = db.Carts
            .AsNoTracking()
            .Where(c => c.IdentityUserId == identityUserId)
            .Select(c => new
            {
                c.ProductId,
                c.Quantity,
                Price = db.Products.Where(p => p.Id == c.ProductId)
                                   .Select(p => p.Price)
                                   .FirstOrDefault()
            })
            .ToList();

        if (!cartItems.Any())
        {
            TempData["OrderSuccess"] = "السلة فاضية.";
            return RedirectToAction("Cart");
        }

        // ✅ Create Order
        var order = new Order
        {
            Name = name,
            Address = address,
            Email = email,
            Mobile = mobile,
            UserNumber = identityUserId
        };

        db.Orders.Add(order);
        db.SaveChanges(); 
        var details = cartItems.Select(item => new OrderDetile
        {
            Productid = item.ProductId,
            Price = item.Price,
            Qty = item.Quantity,
            TotelPrice = (int)(item.Price * item.Quantity),
            OrderId = order.Id
        }).ToList();

        db.OrderDetiles.AddRange(details);

     
        var cartsToRemove = db.Carts
            .Where(c => c.IdentityUserId == identityUserId)
            .ToList();

        db.Carts.RemoveRange(cartsToRemove);

        db.SaveChanges();

        TempData["OrderSuccess"] = "✅ تم توصيل الطلب بنجاح";
        return RedirectToAction("Cart");
    }

}
