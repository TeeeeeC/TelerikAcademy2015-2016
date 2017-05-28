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

    [TestClass]
    public class BrandsControllerTests
    {
        private Mock<IProductsService> productServiceMock;
        private AutoMapperConfig autoMapperConfig;
        private List<Product> products;

        [TestInitialize]
        public void Initialize()
        {
            this.autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(BrandsController).Assembly);
            this.productServiceMock = new Mock<IProductsService>();
            this.products = new List<Product>()
                {
                    new Product
                    {
                        Id = 1,
                        Likes = new List<Like>()
                        {
                            new Like { ProductId = 2, UserId = "358a76f4-9a0e-4b03-a1db-111ede738596" },
                            new Like { ProductId = 2, UserId = "3fdac7f2-6b48-4cdf-b50b-aae093021e26" },
                        },
                        Title = "Product 1",
                        Brand = new Brand { Name = "Adidas" },
                        Price = 5
                    },
                    new Product
                    {
                        Id = 2,
                        Likes = new List<Like>()
                        {
                            new Like { ProductId = 2, UserId = "358a76f4-9a0e-4b03-a1db-111ede738596" },
                            new Like { ProductId = 2, UserId = "3fdac7f2-6b48-4cdf-b50b-aae093021e26" },
                            new Like { ProductId = 2, UserId = "5a610ecd-bdc4-426b-9667-32af8ceb6326" }
                        },
                        Title = "Product 2",
                        Brand = new Brand { Name = "Nike" },
                        Price = 10
                    },
                    new Product
                    {
                        Id = 3,
                        Likes = new List<Like>()
                        {
                            new Like { ProductId = 3, UserId = "358a76f4-9a0e-4b03-a1db-111ede738596" }
                        },
                        Title = "Product 3",
                        Brand = new Brand { Name = "Puma" },
                        Price = 15
                    }
                };
        }

        [TestMethod]
        public void IndexPageShouldWorkCorrectlyWithOutPassingParameters()
        {
            IQueryable<Product> productsAsQueryable = this.products.AsQueryable();
            productServiceMock.Setup(h => h.GetAllByBrand(null, null))
                .Returns(productsAsQueryable);

            var controller = new BrandsController(productServiceMock.Object);
            controller.WithCallTo(h => h.Index(null, 1, null, "Likes", "Desc"))
                .ShouldRenderPartialView("_ProductsPartial")
                .WithModel<PaginationViewModel>(viewModel =>
                {
                    Assert.AreEqual(3, viewModel.Products.Count);
                    Assert.AreEqual("Product 2", viewModel.Products.FirstOrDefault().Title);
                })
                .AndNoModelErrors();
        }

        [TestMethod]
        public void IndexPageShouldWorkCorrectlyPassingBrandName()
        {
            IQueryable<Product> productsAsQueryable = this.products.AsQueryable();
            productServiceMock.Setup(h => h.GetAllByBrand("Adidas", null))
                .Returns(productsAsQueryable.Where(p => p.Brand.Name == "Adidas"));

            var controller = new BrandsController(productServiceMock.Object);
            controller.WithCallTo(h => h.Index("Adidas", 1, null, "Likes", "Desc"))
                .ShouldRenderPartialView("_ProductsPartial")
                .WithModel<PaginationViewModel>(viewModel =>
                {
                    Assert.AreEqual(1, viewModel.Products.Count);
                })
                .AndNoModelErrors();
        }

        [TestMethod]
        public void IndexPageShouldWorkCorrectlyPassingQuery()
        {
            const string Query = "Product 2";
            IQueryable<Product> productsAsQueryable = this.products.AsQueryable();
            productServiceMock.Setup(h => h.GetAllByBrand(null, Query))
                .Returns(productsAsQueryable.Where(p => p.Title.Contains(Query)));

            var controller = new BrandsController(productServiceMock.Object);
            controller.WithCallTo(h => h.Index(null, 1, Query, "Likes", "Desc"))
                .ShouldRenderPartialView("_ProductsPartial")
                .WithModel<PaginationViewModel>(viewModel =>
                {
                    Assert.AreEqual(1, viewModel.Products.Count);
                })
                .AndNoModelErrors();
        }

        [TestMethod]
        public void IndexPageShouldWorkCorrectlyPassingSortByPriceDesc()
        {
            const string SortBy = "Price";
            IQueryable<Product> productsAsQueryable = this.products.AsQueryable();
            productServiceMock.Setup(h => h.GetAllByBrand(null, null))
                .Returns(productsAsQueryable);

            var controller = new BrandsController(productServiceMock.Object);
            controller.WithCallTo(h => h.Index(null, 1, null, SortBy, "Desc"))
                .ShouldRenderPartialView("_ProductsPartial")
                .WithModel<PaginationViewModel>(viewModel =>
                {
                    Assert.AreEqual("Product 3", viewModel.Products.FirstOrDefault().Title);
                })
                .AndNoModelErrors();
        }

        [TestMethod]
        public void IndexPageShouldWorkCorrectlyPassingSortByLikesAsc()
        {
            const string SortBy = "Likes";
            IQueryable<Product> productsAsQueryable = this.products.AsQueryable();
            productServiceMock.Setup(h => h.GetAllByBrand(null, null))
                .Returns(productsAsQueryable);

            var controller = new BrandsController(productServiceMock.Object);
            controller.WithCallTo(h => h.Index(null, 1, null, SortBy, "Asc"))
                .ShouldRenderPartialView("_ProductsPartial")
                .WithModel<PaginationViewModel>(viewModel =>
                {
                    Assert.AreEqual("Product 3", viewModel.Products.FirstOrDefault().Title);
                })
                .AndNoModelErrors();
        }
    }
}
