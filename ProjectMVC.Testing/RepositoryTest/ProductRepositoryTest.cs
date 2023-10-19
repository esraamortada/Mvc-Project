using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using projectmvc.Models;
using projectmvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace projectmvc.test.RepositoryTest
{
    [TestFixture]

    public class ProductRepositoryTest
    {
        public ProductsRepository productrepository;

        [SetUp]
        public void SetUp()
        {
            productrepository = new ProductsRepository();
        }
        [Test]

        public void product_GetAllISNOTEmpty_test()
        {

            var result = productrepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void product_GetAll_NumberofItems()
        {

            var result = productrepository.GetAll();

            Assert.That(result, Has.Exactly(2).Items);

        }

        [Test]

        public void product_ColorsISNOTEmpty_test()
        {
            var result = productrepository.Colors(2);

            Assert.That(result, Is.Not.Empty);

        }

        [Test]

        public void product_SizesISNOTEmpty_test()
        {
            var result = productrepository.sizes(2);

            Assert.That(result, Is.Not.Empty);

        }
        [Test]
        public void proguct_GetBy_Id_isnotnull_Test()
        {
            var result = productrepository.GetById(2);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void proguct_GetAll_Contain_Test()
        {
            var result = productrepository.GetAll();
            Assert.That(result.Select(r => r.Name), Does.Contain("dress").IgnoreCase);
        }


        [Test]
        public void proguct_GetAll_Uniqe_Test()
        {
            var result = productrepository.GetAll();
            Assert.That(result.Select(r => r.Id), Is.Unique);
        }

        [Test]
        public void Product_GetAll_Equalto_Test()
        {
            var result = productrepository.GetAll();


            Assert.That(result.Select(r => r.Name),
                Has.Exactly(1).EqualTo("dress")
                .And.Exactly(1).EqualTo("Jeanse"));
        }














    }
}
