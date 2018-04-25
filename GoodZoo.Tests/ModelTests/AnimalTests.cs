using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoodZoo.Models;

namespace GoodZoo.Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void GetName_ReturnsAnimalName_String()
        {
            //Arrange
            var animal = new Animal("Dog");
            //Act
            var result = animal.Name;
            //Assert
            Assert.AreEqual("Dog", result);

        }
    }
}
