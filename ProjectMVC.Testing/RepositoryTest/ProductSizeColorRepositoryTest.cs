using NUnit.Framework;
using projectmvc.Models;
using projectmvc.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectmvc.test.RepositoryTest
{
    [TestFixture]
    public class ProductSizeColorRepositoryTest
    {
        public ProductSizeColorRepository productSizeColorRepository;

        [SetUp]
        public void SetUp()
        {
            productSizeColorRepository = new ProductSizeColorRepository();
        }
        [Test]

        public void ProductSizeColor_GetAllISNOTEmpty_test()
        {

            var result = productSizeColorRepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void ProductSizeColor_GetAll_NumberofItems()
        {

            var result = productSizeColorRepository.GetAll();

            Assert.That(result, Has.Exactly(2).Items);

        }





        [Test]
        public void ProductSizeColor_GetBy_Id_isnotnull_Test()
        {
            var result = productSizeColorRepository.GetById(2);
            Assert.That(result, Is.Not.Null);
        }



        [Test]
        public void ProductSizeColor_GetAll_Uniqe_Test()
        {
            var result = productSizeColorRepository.GetAll();
            Assert.That(result.Select(r => r.ID), Is.Unique);
        }

        [Test]
        public void ProductSizeColor_GetProductSizeColor_isnotnull_Test()
        {
            var result = productSizeColorRepository.GetProductSizeColor(1);
            Assert.That(result, Is.Not.Null);
        }


        [Test]
        public void ProductSizeColor_GetLists_isnotnull_Test()
        {
            var result = productSizeColorRepository.GetLists(2);
            Assert.That(result, Is.Not.Null);
        }
        [Test]
        public void Insert_AddAddProduct_Test()
        {


            ProductSizeColor p = new ProductSizeColor { ProductID = 2, ProductColorID = 1, ProductSizeID = 1, Quantity = 5 };
            productSizeColorRepository.Insert(p);
            var result = productSizeColorRepository.GetAll();


            Assert.That(result.Count, Is.EqualTo(3));

        }



    }
}
