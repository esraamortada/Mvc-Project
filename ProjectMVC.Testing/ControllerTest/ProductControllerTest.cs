using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using projectmvc.Controllers;
using projectmvc.Hubs;
using projectmvc.Repository;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectmvc.test.ContollerTest
{
    [TestFixture]
    public class ProductControllerTest
    {
        //[Test]
        //public void AllProduct_test()
        //{
        //    IProductsRepository productsRepository = new ProductsRepository();
        //    IProductSizeColorRepository productSizeColorRepository =new ProductSizeColorRepository();

        //    IHubContext<AddCommentHub> hubContext = new HubContext<AddCommentHub>(
        //    new DefaultHubLifetimeManager<AddCommentHub>(),
        //    new LoggerFactory().CreateLogger<HubContext<AddCommentHub>>()
        //    );

        //    ICartRepository cartRepository = new CartRepository();

        //    ProductController ProductController = new ProductController(productsRepository, productSizeColorRepository,cartRepository,hubContext);
        //    var ViewResult = ProductController.AllProduct() as ViewResult;
        //     Assert.IsNotNull(ViewResult);


        //}

        //[Test]
        //public void Singleproduct_isnot_null_Test()
        //{
        //    IProductsRepository productsRepository = new ProductsRepository();
        //    IProductSizeColorRepository productSizeColorRepository = new ProductSizeColorRepository();
        //    IHubContext<AddCommentHub> hubContext;
        //    ICartRepository cartRepository = new CartRepository();
        //    ProductController ProductController = new ProductController(productsRepository, productSizeColorRepository, cartRepository, hubContext);
        //    var ViewResult = ProductController.SingleProduct(2) as ViewResult;
        //    Assert.IsNotNull(ViewResult);


        //}

    }
}
