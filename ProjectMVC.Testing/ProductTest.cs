using NUnit.Framework;
using projectmvc.Models;

namespace projectmvc.test
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void Check_That_Class_Contain_Name_Property()
        {
            Product product = new Product();


            Assert.That(product, Has.Property("Name"));
        }

   



        

    }
}