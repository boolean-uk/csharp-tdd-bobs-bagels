﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests
{
    [TestFixture]
    internal class BasketTest
    {

        [Test]
        public void Add() 
        {
            // arrange 
            Basket core = new Basket();
            string bagel = "cream bagel";

            // act
            core.basket.Add(bagel);
            string result = core.basket.First();
            int length = core.basket.Count();

            // assert
            Assert.That(result, Is.EqualTo(bagel));
            Assert.That(length, Is.EqualTo(1));            
        }

        [Test]
        public void Remove()
        {
            // arrange 
            Basket core = new Basket();
            string bagel = "cream bagel";
            core.basket.Add(bagel);

            // act
            bool result = core.Remove(bagel);
            int length = core.basket.Count();
            
            // assert
            Assert.That(result, Is.True);
            Assert.That(length, Is.EqualTo(0));
        }
    }
}
