using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        private string Make { get; set; }
        private string Model { get; set; }
        private float GasTankSizeInGallons { get; set; }
        private float TotalMiles { get; set; }
        private float MPG { get; set; }
        private float AvailableGas { get; set; }

        public void Print()
        {
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model; " + Model);
            Console.WriteLine("Gas Tank Size In Gallons: " + GasTankSizeInGallons);
            Console.WriteLine("Total Miles: " + TotalMiles);
            Console.WriteLine("MPG: " + MPG);
            Console.WriteLine("Available Gas: " + AvailableGas);

        }

        public bool HasEnoughGas(float miles)
        {
            float availableMiles = (AvailableGas / MPG);
            return availableMiles >= miles;
        }

        public void AddMiles(float howManyMilesToAdd)
        {
            float gasToBeConsumed = howManyMilesToAdd / MPG;
            AvailableGas = AvailableGas - gasToBeConsumed;
            TotalMiles = TotalMiles + howManyMilesToAdd;

        }

        public void AddGas(float gasToAdd)
        {
            float currentAmountOfGas = (AvailableGas + gasToAdd);
            if (currentAmountOfGas >= GasTankSizeInGallons)
            {
                AvailableGas = GasTankSizeInGallons;
            }
            else
            {
                AvailableGas = currentAmountOfGas;
            }
        }
    }

}
