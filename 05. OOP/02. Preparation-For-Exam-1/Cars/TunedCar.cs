using System;

namespace CarRacing.Models.Cars
{
    public class TunedCar : Car
    {
        public TunedCar(string make, string model, string VIN, int horsePower)
            : base(make, model, VIN, horsePower, 65, 7.5)
        {
        }

        public override void Drive()
        {
            var engineWearReduce = ((FuelAvailable - FuelConsumptionPerRace) / 100) * 3;
            HorsePower = (int)Math.Round(FuelAvailable - FuelConsumptionPerRace - engineWearReduce);
        }
    }
}