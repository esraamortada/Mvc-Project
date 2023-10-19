using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using projectmvc.Controllers;
using projectmvc.Repository;


namespace projectmvc.test.ContollerTest
{
    [TestFixture]
    public class SubCategoryControllerTest
    {
        [Test]
        public void subcategory_AllProduct_test()
        {
            ISubCategoryRepository subcategoryRepository = new SubCategoryRepository();
            ICategoryRepository categoryRepository = new CategoryRepository();

            IProductsRepository productsRepository = new ProductsRepository();
            IProductSizeColorRepository productSizeColorRepository = new ProductSizeColorRepository();
            ICartRepository cartRepository = new CartRepository();

            SubCategoryController subcategorycontroller = new SubCategoryController(productsRepository, productSizeColorRepository, cartRepository, categoryRepository, subcategoryRepository);
            var ViewResult = subcategorycontroller.AllProduct() as ViewResult;
            Assert.IsNotNull(ViewResult);


        }


    }
}
