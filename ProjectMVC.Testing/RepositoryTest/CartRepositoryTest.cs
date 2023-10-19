using NUnit.Framework;
using projectmvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectmvc.test
{
    [TestFixture]
    public class CartRepositoryTest
    {

        public CartRepository cartRepository;

        [SetUp]
        public void SetUp()
        {
            cartRepository = new CartRepository();
        }
        [Test]

        public void cart_GetAllISNOTEmpty_test()
        {

            var result = cartRepository.GetAll("819693b8-110d-4b79-9e15-d90a535d956b");

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void Cart_GetAll_NumberofItems()
        {

            var result = cartRepository.GetAll("819693b8-110d-4b79-9e15-d90a535d956b");

            Assert.That(result, Has.Exactly(2).Items);

        }


        [Test]
        public void cart_GetBy_Id_isnotnull_Test()
        {
            var result = cartRepository.GetById(4);
            Assert.That(result, Is.Not.Null);
        }


        [Test]
        public void Cart_Delete_Test()
        {
            int CartID = 4;
            cartRepository.Delete(CartID);
             Assert.IsNull(cartRepository.GetById(CartID));
          




        }

        [Test]
        public void Cart_Delete_Test2()
        {
            int CartID = 5;
            cartRepository.Delete(CartID);
            var result = cartRepository.GetAll("1d6234b5-dfd1-4da5-9ec5-b61dfa65b87d");
            Assert.That(result, Has.Exactly(0).Items);

           




        }

        

    }
}
