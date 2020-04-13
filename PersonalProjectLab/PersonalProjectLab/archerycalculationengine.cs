using System;
namespace PersonalProjectLab
{
    public class archerycalculationengine
    {
        public archerycalculationengine()
        {

        }
        public double CalculateArrowSpeed(double bowPound, double arrowWeight, double drawLength)
        {
            double arrowAcceleration;
            double veloSquared;
            double arrowSpeed;

            arrowAcceleration = bowPound / arrowWeight;
            veloSquared = 2 * arrowAcceleration * drawLength;
            arrowSpeed = Math.Sqrt(veloSquared);

            return Math.Round( arrowSpeed,3);
             
        }
        public double CalculateKineticEnergy(double arrowWeight, double arrowVelo)
        {
            
            double veloSquared;
            double kineticEnergy;

            veloSquared = arrowVelo * arrowVelo;
            kineticEnergy = 0.5 * arrowWeight * veloSquared;

            return Math.Round(kineticEnergy,3);

        }
        

    }
}
