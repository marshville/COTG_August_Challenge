using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace COTGPetshop.Common.Tests
{
    [TestClass]
    public class PetTaxStrategyTests
    {
        [TestMethod]
        public void CalculateVatFromNetTest()
        {
            PetTaxStrategy sut = new PetTaxStrategy(18.0M, 0.01M, 4);

            decimal expected = 0.18M;

            decimal actual = sut.CalculateVatFromNet(1.00M);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateVatFromGrossTest()
        {
            PetTaxStrategy sut = new PetTaxStrategy(18.0M, 0.01M, 4);

            decimal expected = 0.18M;

            decimal actual = sut.CalculateVatFromGross(1.18M);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateVatFromNetZeroRateTest()
        {
            PetTaxStrategy sut = new PetTaxStrategy(0.0M, 0.01M, 4);

            decimal expected = 0.0M;

            decimal actual = sut.CalculateVatFromNet(1.00M);

            Assert.AreEqual(expected, actual);            
        }
        [TestMethod]
        public void CalculateVatFromNetZeroNetTest()
        {
            PetTaxStrategy sut = new PetTaxStrategy(18.0M, 0.01M, 4);

            decimal expected = 0.0M;

            decimal actual = sut.CalculateVatFromNet(0.00M);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateVatFromNetZeroRateAndZeroNetTest()
        {
            PetTaxStrategy sut = new PetTaxStrategy(0.0M, 0.01M, 4);

            decimal expected = 0.0M;

            decimal actual = sut.CalculateVatFromNet(0.00M);

            Assert.AreEqual(expected, actual);
        }

    }
}
