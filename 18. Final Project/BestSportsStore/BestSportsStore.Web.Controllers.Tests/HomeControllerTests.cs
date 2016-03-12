namespace BestSportsStore.Web.Controllers.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Infrastructure.Mapping;
    using Moq;
    using Services.Contracts;
    using System.Collections.Generic;
    using Data.Models;
    using System.Linq;
    using TestStack.FluentMVCTesting;
    using Models.Product;
    using Models.Menu;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    [TestClass]
    public class HomeControllerTests
    {
        private Mock<IHomeService> homeServiceMock;
        private AutoMapperConfig autoMapperConfig;

        [TestInitialize]
        public void Initialize()
        {
            this.autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(HomeController).Assembly);
            this.homeServiceMock = new Mock<IHomeService>();
        }

        [TestMethod]
        public void IndexPageShouldWorkCorrectly()
        {
            var products = new List<Product>()
                {
                    new Product
                    {
                        Id = 1,
                        Likes = new List<Like>()
                        {
                            new Like { ProductId = 2, UserId = "358a76f4-9a0e-4b03-a1db-111ede738596" },
                            new Like { ProductId = 2, UserId = "3fdac7f2-6b48-4cdf-b50b-aae093021e26" },
                            new Like { ProductId = 2, UserId = "5a610ecd-bdc4-426b-9667-32af8ceb6326" }
                        },
                        Title = "Product 1"
                    },
                    new Product
                    {
                        Id = 2,
                        Likes = new List<Like>()
                        {
                            new Like { ProductId = 2, UserId = "358a76f4-9a0e-4b03-a1db-111ede738596" },
                            new Like { ProductId = 2, UserId = "3fdac7f2-6b48-4cdf-b50b-aae093021e26" }
                        },
                        Title = "Product 2"
                    },
                    new Product
                    {
                        Id = 3,
                        Likes = new List<Like>()
                        {
                            new Like { ProductId = 3, UserId = "358a76f4-9a0e-4b03-a1db-111ede738596" }
                        },
                        Title = "Product 3"
                    }
                };

            IQueryable<Product> productsAsQueryable = products.AsQueryable();
            homeServiceMock.Setup(h => h.GetTopProducts(It.IsAny<int>()))
                .Returns(productsAsQueryable);

            var controller = new HomeController(homeServiceMock.Object);
            controller.WithCallTo(h => h.Index())
                .ShouldRenderView("Index")
                .WithModel<List<ProductViewModel>>(viewModel =>
                {
                    Assert.AreEqual(3, viewModel.Count);
                    Assert.AreEqual(3, viewModel[0].Likes.Count);
                    Assert.AreEqual("Product 1", viewModel[0].Title);
                    Assert.AreEqual("Product 2", viewModel[1].Title);
                    Assert.AreEqual("Product 3", viewModel[2].Title);
                })
                .AndNoModelErrors();
        }

        [TestMethod]
        public void MenuShouldWorkCorrectly()
        {
            var categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Mens"},
                new Category { Id = 2, Name = "Ladies"},
                new Category { Id = 3, Name = "Kids"},
            };

            var sports = new List<Sport>()
            {
                new Sport { Id = 1, Name = "Football"},
                new Sport { Id = 2, Name = "Running"},
                new Sport { Id = 3, Name = "Fitness"},
            };

            var brands = new List<Brand>()
            {
                new Brand { Id = 1, Name = "Adidas"},
                new Brand { Id = 2, Name = "Nike"},
                new Brand { Id = 3, Name = "Puma"},
            };

            homeServiceMock.Setup(h => h.GetCategories()).Returns(categories.AsQueryable());
            homeServiceMock.Setup(h => h.GetSports()).Returns(sports.AsQueryable());
            homeServiceMock.Setup(h => h.GetBrands()).Returns(brands.AsQueryable());

            var controller = new HomeController(homeServiceMock.Object);
            var context = new Mock<HttpContextBase>();
            context.Setup(c => c.Cache).Returns(HttpRuntime.Cache);
            controller.ControllerContext = new ControllerContext(context.Object, new RouteData(), controller);
            controller.WithCallTo(h => h.Menu())
                .ShouldRenderPartialView("_NavigationPartial")
                .WithModel<MenuViewModel>(viewModel =>
                {
                    Assert.AreEqual(3, viewModel.Categories.Count);
                    Assert.AreEqual(3, viewModel.Sports.Count);
                    Assert.AreEqual(3, viewModel.Brands.Count);
                    Assert.AreEqual("Mens", viewModel.Categories.FirstOrDefault().Name);
                    Assert.AreEqual("Football", viewModel.Sports.FirstOrDefault().Name);
                    Assert.AreEqual("Puma", viewModel.Brands.LastOrDefault().Name);
                })
                .AndNoModelErrors();
        }
    }
}
