namespace BestSportsStore.Web.Controllers
{
    using Microsoft.AspNet.Identity;
    using Models.Orders;
    using Models.Product;
    using Models.Shopping;
    using Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class BuyController : BaseController
    {
        private const string UserIdCard = "userIdCard";

        private IShoppingService shoppingService;

        public BuyController(IProductsService productsService, IShoppingService shoppingService)
            : base(productsService)
        {
            this.shoppingService = shoppingService;
        }

        public ActionResult Index(int productId, int productSize, string url)
        {
            if (Request.Cookies[UserIdCard] == null)
            {
                var guid = Guid.NewGuid().ToString();
                this.shoppingService.AddShoppingCart(productId, productSize, guid);
                this.Response.Cookies[UserIdCard].Value = guid;
                this.Response.Cookies[UserIdCard].Expires = DateTime.Now.AddDays(3);
            }
            else
            {
                var userId = this.Request.Cookies[UserIdCard].Value;
                this.shoppingService.UpdateShoppingCart(productId, productSize, userId);
            }

            return Redirect(url);
        }

        public ActionResult ShoppingCart()
        {
            ShoppingCartViewModel cart;
            if (Request.Cookies[UserIdCard] != null)
            {
                cart = this.Mapper.Map<ShoppingCartViewModel>(this.shoppingService.GetByUserId(Request.Cookies[UserIdCard].Value));
            }
            else
            {
                cart = new ShoppingCartViewModel { ProductsCount = 0 };
            }

            return PartialView("_ShoppingCart", cart);
        }

        [HttpGet]
        public ActionResult Order()
        {
            OrderViewModel viewModel = new OrderViewModel { ProductIds = null };
            if (this.Request.Cookies[UserIdCard] != null)
            {
                var cart = this.shoppingService.GetByUserId(Request.Cookies[UserIdCard].Value);
                if (cart.ProductsCount > 0)
                {
                    var productsIds = cart.ProductIds.Split(new string[] { "," } ,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    var productsAsQuerable = this.ProductsService.GetByIds(productsIds).ToList();
                    var products = this.Mapper.Map<List<ProductViewModel>>(productsAsQuerable);

                    var sizes = cart.Sizes.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    var productTitles = string.Empty;
                    for (int i = 0; i < productsIds.Count; i++)
                    {
                        var product = products.Find(p => p.Id == productsIds[i]);
                        product.SizeValues += sizes[i] + ",";
                        productTitles += product.Title + ",";
                    }

                    for (int i = 0; i < products.Count; i++)
                    {
                        var countSizes = products[i].SizeValues.Count(c => c == ',');
                        if (countSizes > 1)
                        {
                            products[i].Price *= countSizes;
                            products[i].Quantity = countSizes;
                        }
                        else
                        {
                            products[i].Quantity = 1;
                        }
                    }

                    viewModel = new OrderViewModel
                    {
                        Products = products,
                        ProductIds = cart.ProductIds,
                        ProductSizes = cart.Sizes,
                        ProductTitles = productTitles,
                        TotalPrice = products.Sum(p => p.Price)
                    };
                }
            }

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Order(OrderViewModel model)
        {
            var productsIds = model.ProductIds.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var products = this.ProductsService.GetByIds(productsIds).ToList();
            var sizes = model.ProductSizes.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < sizes.Count; i++)
            {
                this.shoppingService.OrderProductBySize(products[i % products.Count].Id, sizes[i]);
            }
            
            this.HttpContext.Response.Cache.SetNoStore();
            var userId = this.HttpContext.User.Identity.GetUserId();
            this.shoppingService.AddOrder(model.TotalPrice, model.ProductIds, model.ProductSizes, userId, 
                Request.Cookies[UserIdCard].Value, model.ProductTitles);

            return Redirect("/orders/index");
        }
    }
}