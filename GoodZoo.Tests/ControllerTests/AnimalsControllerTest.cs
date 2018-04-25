using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoodZoo.Models;
using Microsoft.AspNetCore.Mvc;
using GoodZoo.Controllers;

namespace GoodZoo.Tests.ControllerTests
{
    class AnimalsControllerTest
    {
        [TestMethod]
        public void AnimalsController_AddsAnimalToIndexModelData_Collection()
        {
            // Arrange
            AnimalsController controller = new AnimalsController();
            Animal testAnimal = new Animal("Louis", "Canine", "Male", "Domestic");
            testAnimal.Name = "Louis";

            // Act
            controller.Create(testAnimal);
            ViewResult indexView = new AnimalsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Animal>;

            // Assert
            CollectionAssert.Contains(collection, testAnimal);
        }
    }
}
