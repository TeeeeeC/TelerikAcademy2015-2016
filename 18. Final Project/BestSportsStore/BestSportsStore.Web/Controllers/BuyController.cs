namespace BestSportsStore.Web.Controllers
{
    using Data.Models;
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
        private const string UserIdCart = "userIdCard";

        private IShoppingService shoppingService;

        public BuyController(IProductsService productsService, IShoppingService shoppingService)
            : base(productsService)
        {
            this.shoppingService = shoppingService;
        }

        public ActionResult Index(int productId, int productSize, string url)
        {
            if (Request.Cookies[UserIdCart] == null)
            {
                var guid = Guid.NewGuid().ToString();
                this.shoppingService.AddShoppingCart(productId, productSize, guid);
                this.Response.Cookies[UserIdCart].Value = guid;
                this.Response.Cookies[UserIdCart].Expires = DateTime.Now.AddDays(3);
            }
            else
            {
                var cardId = this.Request.Cookies[UserIdCart].Value;
                this.shoppingService.UpdateShoppingCart(productId, productSize, cardId);
            }

            return Redirect(url);
        }

        public ActionResult ShoppingCart()
        {
            ShoppingCartViewModel cart;
            if (Request.Cookies[UserIdCart] != null)
            {
                cart = this.Mapper.Map<ShoppingCartViewModel>(this.shoppingService.GetByUserId(Request.Cookies[UserIdCart].Value));
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
            var viewModel = new OrderViewModel();
            if (this.Request.Cookies[UserIdCart] != null)
            {
                var cart = this.shoppingService.GetByUserId(Request.Cookies[UserIdCart].Value);
                if (cart.ProductsCount > 0)
                {
                    var productsIds = cart.ProductIds.Split(new string[] { "," } ,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    var productsAsQuerable = this.ProductsService.GetByIds(productsIds).ToList();
                    var products = this.Mapper.Map<List<ProductViewModel>>(productsAsQuerable);

                    var sizes = cart.Sizes.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    for (int i = 0; i < products.Count; i++)
                    {
                        products[i].Sizes.Clear();
                    }

                    for (int i = 0; i < sizes.Count; i++)
                    {
                        var product = products.FirstOrDefault(p => p.Id == productsIds[i]);
                        product.Sizes.Add(new SizeViewModel { Value = (short)sizes[i] });
                    }

                    viewModel = new OrderViewModel
                    {
                        Products = products,
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
            for (int i = 0; i < model.Products.Count; i++)
            {
                this.shoppingService.OrderProductBySize(model.Products[i].Id, model.Products[i].Sizes.FirstOrDefault().Value);
            }
            
            this.HttpContext.Response.Cache.SetNoStore();
            var userId = this.HttpContext.User.Identity.GetUserId();
            this.shoppingService.AddOrder(model.TotalPrice, userId, this.Mapper.Map<List<Product>>(model.Products),
                Request.Cookies[UserIdCart].Value);

            return Redirect("/orders/index");
        }

        public ActionResult RemoveFromCart(int productId, int sizeValue, string url)
        {
            var cartId = this.Request.Cookies[UserIdCart].Value;
            this.shoppingService.DeleteItemFromShoppingCart(productId, sizeValue, cartId);
            return Redirect(url);
        }
    }
}