using NUnit.Framework;
using projectmvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectmvc.test.RepositoryTest
{
    [TestFixture]
    public class CategoryRepositoryTest
    {
        public CategoryRepository categoryRepository;

        [SetUp]
        public void SetUp()
        {
            categoryRepository = new CategoryRepository();
        }
        [Test]

        public void Category_GetAllISNOTEmpty_test()
        {

            var result = categoryRepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void Category_GetAll_NumberofItems()
        {

            var result = categoryRepository.GetAll();

            Assert.That(result, Has.Exactly(3).Items);

        }




        [Test]
        public void Category_GetBy_Id_isnotnull_Test()
        {
            var result = categoryRepository.GetById(3);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Category_GetAll_Contain_Test()
        {
            var result = categoryRepository.GetAll();
            Assert.That(result.Select(r => r.Name), Does.Contain("Women").IgnoreCase);
        }

        [Test]
        public void Category_GetAll_Uniqe_Test()
        {
            var result = categoryRepository.GetAll();
            Assert.That(result.Select(r => r.Id), Is.Unique);
        }


        [Test]
        public void Category_GetAll_Equalto_Test()
        {
            var result = categoryRepository.GetAll();


            Assert.That(result.Select(r => r.Name),
                Has.Exactly(1).EqualTo("Women")
                .And.Exactly(1).EqualTo("Men"));
        }






    }
}
