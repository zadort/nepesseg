using NUnit.Framework;

namespace nepesseg.Tests
{
    [TestFixture]
    public class OrszagTests
    {
        [Test]
        public void Nepsuruseg_ValidInput_ReturnsCorrectDensity()
        {
            // Arrange
            var orszag = new Orszag("Hungary;93030;9800000;Budapest;1750000");

            // Act
            var density = orszag.Nepsuruseg();

            // Assert
            Assert.AreEqual(105.33, density); // 9800000 / 93030 rounded to 2 decimal places
        }

        [Test]
        public void Nepsuruseg_ZeroArea_ThrowsDivideByZeroException()
        {
            // Arrange
            var orszag = new Orszag("LandOfZeroArea;0;1000000;City;500000");

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => orszag.Nepsuruseg());
        }

        [Test]
        public void HarmincSzazalek_FiftyPercentPopulationInCapital_ReturnsTrue()
        {
            // Arrange
            var orszag = new Orszag("CountryX;500000;1000000;Capitol;500000");

            // Act
            var result = orszag.HarmincSzazalek();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void HarmincSzazalek_ThirtyPercentPopulationInCapital_ReturnsFalse()
        {
            // Arrange
            var orszag = new Orszag("CountryY;500000;1000000;Capitol;300000");

            // Act
            var result = orszag.HarmincSzazalek();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
