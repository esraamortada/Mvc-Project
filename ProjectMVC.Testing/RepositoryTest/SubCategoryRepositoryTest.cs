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
    public class SubCategoryRepositoryTest
    {
        public SubCategoryRepository subCategoryRepository;

        [SetUp]
        public void SetUp()
        {
            subCategoryRepository = new SubCategoryRepository();
        }
        [Test]

        public void SubCategory_GetAllISNOTEmpty_test()
        {

            var result = subCategoryRepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void SubCategory_GetAll_NumberofItems()
        {

            var result = subCategoryRepository.GetAll();

            Assert.That(result, Has.Exactly(6).Items);

        }




        [Test]
        public void SubCategory_GetBy_Id_isnotnull_Test()
        {
            var result = subCategoryRepository.GetById(7);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void SubCategory_GetAll_Contain_Test()
        {
            var result = subCategoryRepository.GetAll();
            Assert.That(result.Select(r => r.Name), Does.Contain("KidsPants").IgnoreCase);
        }

        [Test]
        public void SubCategory_GetAll_Uniqe_Test()
        {
            var result = subCategoryRepository.GetAll();
            Assert.That(result.Select(r => r.Id), Is.Unique);
        }


        [Test]
        public void SubCategory_GetAll_Equalto_Test()
        {
            var result = subCategoryRepository.GetAll();


            Assert.That(result.Select(r => r.Name),
                Has.Exactly(1).EqualTo("KidsPants")
                .And.Exactly(1).EqualTo("KidsShirts"));
        }
    }
}
