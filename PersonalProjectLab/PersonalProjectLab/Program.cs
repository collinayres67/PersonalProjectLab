using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int calcIndicator;
            string input;

            Console.WriteLine("Enter 1 for arrow speed or 3 for kinetic energy of arrow");
            input = Console.ReadLine();
            calcIndicator = int.Parse(input);

            if (calcIndicator < 2)
            {
                double bowPound;
                double arrowWeight;
                double drawLength;
      
                double arrowSpeed;
                archerycalculationengine engine = new archerycalculationengine();


                Console.WriteLine("Enter bow poundage in Newtons");
                input = Console.ReadLine();
                bowPound = double.Parse(input);


                Console.WriteLine("Enter arrow weight in Kg");
                input = Console.ReadLine();
                arrowWeight = double.Parse(input);


                Console.WriteLine("Enter draw length in Meters");
                input = Console.ReadLine();
                drawLength = double.Parse(input);

                arrowSpeed = engine.CalculateArrowSpeed(bowPound, arrowWeight, drawLength);


                Console.WriteLine("Arrow speed =" + arrowSpeed);



            }
            else
            {
                double arrowWeight;
                double arrowVelo;
                double kineticEnergy;
                archerycalculationengine engine = new archerycalculationengine();


                Console.WriteLine("Enter arrow weight in Kg");
                input = Console.ReadLine();
                arrowWeight = double.Parse(input);

                Console.WriteLine("Enter arrow velocity in m/s");
                input = Console.ReadLine();
                arrowVelo = double.Parse(input);

                kineticEnergy = engine.CalculateKineticEnergy(arrowWeight, arrowVelo);

                Console.WriteLine("Kinetic energy =" + kineticEnergy);

            }

            

        }
    }
}