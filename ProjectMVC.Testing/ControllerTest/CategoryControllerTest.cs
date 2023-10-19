using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using projectmvc.Controllers;
using projectmvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectmvc.test.ContollerTest
{
    [TestFixture]
    public class CategoryControllerTest
    {
        //{
        //    IProductsRepository productsRepository ;
        //    IProductSizeColorRepository ProductSizeColorRepository;
        //    ICartRepository cartRepository ;
        //    ICategoryRepository categoryRepository ;
        //    ISubCategoryRepository subCategoryRepository ;
        //    [SetUp]
        //    public void SetUP()
        //    {
        //        productsRepository = new ProductsRepository();
        //        ProductSizeColorRepository = new ProductSizeColorRepository();
        //        cartRepository = new CartRepository();
        //        categoryRepository = new CategoryRepository();
        //        subCategoryRepository = new SubCategoryRepository();

        //    }



        //    [Test]
        //    public void Index_test()
        //    {


        //        CategoryController categoryController = new CategoryController(productsRepository, ProductSizeColorRepository, cartRepository,categoryRepository, subCategoryRepository);
        //        var ViewResult = categoryController.Index() as ViewResult;
        //        Assert.IsNotNull(ViewResult);


        //    }

        //    [Test]
        //    public void GetAllProductByCategory_test()
        //    {


        //        CategoryController categoryController = new CategoryController(productsRepository, ProductSizeColorRepository, cartRepository, categoryRepository, subCategoryRepository);
        //        var ViewResult = categoryController.GetAllProductByCategory(2) as ViewResult;
        //        Assert.IsNotNull(ViewResult);


        //    }



    }
}
