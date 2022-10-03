using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        private CoffeeController _coffeeController;

        [SetUp]
        public void SetUp()
        {
            _coffeeController = new CoffeeController();
        }
        [Test]
        public void TestGetCoffee()
        {
            string expectedContent = "I like coffee!";

           // var controller = new CoffeeController();
            var result = _coffeeController.GetCoffeeLover();

            Assert.AreEqual(expectedContent, result);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void TestCoffeenameParameter(string name)
        {
            string expectedName = "latte";
            int expectedID = -1;

            var result = _coffeeController.Get(name);
            Assert.AreEqual(expectedName, result.Name );
            Assert.AreEqual(expectedID, result.ID );
        }

        [Test]
        public void ReturnCoffeeNameWithCodeTest()
        {
            string expectedName = "cappuccino";
            int expectedID = 7;
            var result = _coffeeController.Get("cappuccino");
            Assert.AreEqual(expectedName, result.Name);
            Assert.AreEqual(expectedID, result.ID);

        }
    }
}
