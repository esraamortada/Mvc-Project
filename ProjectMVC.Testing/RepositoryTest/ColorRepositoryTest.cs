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
    public class ColorRepositoryTest
    {
        public ColorRepository colorRepository;

        [SetUp]
        public void SetUp()
        {
            colorRepository = new ColorRepository();
        }
        [Test]

        public void Color_GetAllISNOTEmpty_test()
        {

            var result = colorRepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void Color_GetAll_NumberofItems()
        {

            var result = colorRepository.GetAll();

            Assert.That(result, Has.Exactly(4).Items);

        }



        [Test]
        public void Color_GetBy_Id_isnotnull_Test()
        {
            var result = colorRepository.GetById(1);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Color_GetAll_Contain_Test()
        {
            var result = colorRepository.GetAll();
            Assert.That(result.Select(r => r.Name), Does.Contain("Blue").IgnoreCase);
        }





    }
}
