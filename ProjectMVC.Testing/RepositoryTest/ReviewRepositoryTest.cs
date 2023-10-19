using Microsoft.CodeAnalysis;
using NUnit.Framework;
using projectmvc.Models;
using projectmvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectmvc.test.RepositoryTest
{
    [TestFixture]
    public class ReviewRepositoryTest
    {
        public ReviewRepository reviewRepository;

        [SetUp]
        public void SetUp()
        {
            reviewRepository = new ReviewRepository();
        }
        [Test]

        public void Review_GetAllISNOTEmpty_test()
        {

            var result = reviewRepository.GetAll();

            Assert.That(result, Is.Not.Empty);

        }


        [Test]
        public void Review_GetAll_NumberofItems()
        {

            var result = reviewRepository.GetAll();

            Assert.That(result, Has.Exactly(7).Items);

        }



        [Test]
        public void Review_GetBy_Id_isnotnull_Test()
        {
            var result = reviewRepository.GetById(1);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Insert_AddAddProduct_Test()
        {






            Review r = new Review { CustomerID = "819693b8-110d-4b79-9e15-d90a535d956b", CustomerName = "aya", ProductID = 2, Comment = "good quality", Rating = 5 };
            reviewRepository.Insert(r);
            var result = reviewRepository.GetAll();


            Assert.That(result.Count, Is.EqualTo(7));

        }



    }
}
