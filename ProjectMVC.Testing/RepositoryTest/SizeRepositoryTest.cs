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
    public class SizeRepositoryTest
    {
        public SizeRepository sizeRepository;

        [SetUp]
        public void SetUp()
        {
            sizeRepository = new SizeRepository();
        }
        [Test]

        public void Size_GetAllISNOTEmpty_test()
        {

            var result = sizeRepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void Size_GetAll_NumberofItems()
        {

            var result = sizeRepository.GetAll();

            Assert.That(result, Has.Exactly(7).Items);

        }



        [Test]
        public void Size_GetBy_Id_isnotnull_Test()
        {
            var result = sizeRepository.GetById(1);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Size_GetAll_Contain_Test()
        {
            var result = sizeRepository.GetAll();
            Assert.That(result.Select(r => r.size), Does.Contain("L").IgnoreCase);
        }

    }
}
