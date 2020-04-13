using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class ArcheryCalculationTests
    {
        [TestMethod]
        public void Archery_CalculateArrowSpeed()
        {
            archerycalculationengine calc = new archerycalculationengine();
            double speed = calc.CalculateArrowSpeed(200, 0.02, 0.7);
            Assert.AreEqual(118.322, speed);

        }

        [TestMethod]

        public void Archery_CalculateKineticEnergy()
        {
            archerycalculationengine calc = new archerycalculationengine();
            double energy = calc.CalculateKineticEnergy(0.02, 150);
            Assert.AreEqual(225, energy);
        }


    }
}
