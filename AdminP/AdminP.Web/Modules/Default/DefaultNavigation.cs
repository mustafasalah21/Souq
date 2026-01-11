using AdminP.Modules.Default.Cart;
using AdminP.Modules.Default.Category;
using AdminP.Modules.Default.Product;
using AdminP.Modules.Default.Productimage;
using Serenity.Navigation;
using MyPages = AdminP.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Category", typeof(CategoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Cart", typeof(CartPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Product", typeof(ProductPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Productimage", typeof(ProductimagePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Review", typeof(MyPages.ReviewPage), icon: null)]