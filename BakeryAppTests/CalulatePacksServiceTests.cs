using BakeryApp;
using NUnit.Framework;
using System.Collections.Generic;

namespace BakeryAppTests
{
    public class CalulatePacksServiceTests
    {
        private ICalulatePacksService _calulatePacksService;

        [SetUp]
        public void Setup()
        {
            _calulatePacksService = new CalulatePacksService();
        }

        [TestCase(14, 54.8)] // positive test
        [TestCase(11, 0)] // negative test
        public void CalculatePacksAndCost_MuffinTest_CheckResults(int quantity, decimal result)
        {
            // Arrange
            var muffin = new BlueberryMuffin() { Quantity = quantity };
            var items = new List<Item>();
            items.Add(muffin);

            // Act
            var calulatePacksService = new CalulatePacksService();
            var orderSummary = calulatePacksService.CalculatePacksAndCost(items);

            // Assert
            Assert.AreEqual(result, orderSummary.OverallCost);
        }

        [TestCase(10, 17.98)]
        [TestCase(7, 0)]
        public void CalculatePacksAndCost_VegemiteScrollTest_CheckResults(int quantity, decimal result)
        {
            // Arrange
            var vegScroll = new VegemiteScroll() { Quantity = quantity };
            var items = new List<Item>();
            items.Add(vegScroll);

            // Act
            var calulatePacksService = new CalulatePacksService();
            var orderSummary = calulatePacksService.CalculatePacksAndCost(items);

            // Assert
            Assert.AreEqual(result, orderSummary.OverallCost);
        }

        [TestCase(13, 25.85)]
        [TestCase(11, 0)]
        public void CalculatePacksAndCost_CroissantTest_CorrectResults(int quantity, decimal result)
        {
            // Arrange
            var croissant = new Croissant() { Quantity = quantity };
            var items = new List<Item>();
            items.Add(croissant);

            // act
            var calulatePacksService = new CalulatePacksService();
            var orderSummary = calulatePacksService.CalculatePacksAndCost(items);

            // Assert
            Assert.AreEqual(result, orderSummary.OverallCost);
        }

        [Test]
        public void CalculatePacksAndCost_AllTest_CorrectResults()
        {
            // Arrange
            var vegScroll = new VegemiteScroll() { Quantity = 10 };
            var muffin = new BlueberryMuffin() { Quantity = 14 };
            var croissant = new Croissant() { Quantity = 13 };

            var items = new List<Item>();
            items.Add(vegScroll);
            items.Add(muffin);
            items.Add(croissant);

            // Act
            var calulatePacksService = new CalulatePacksService();
            var orderSummary = calulatePacksService.CalculatePacksAndCost(items);

            // Assert
            Assert.AreEqual(98.63, orderSummary.OverallCost);
        }
    }
}