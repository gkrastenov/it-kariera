using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;

namespace CarRacing.Models.Cars
{
    public abstract class Car : ICar
    {
        private string make;
        private string model;
        private string vin;
        private int horsePower;
        private double fuelAvailable;
        private double fuelConsumptionPerRace;

        public Car(string make, string model, string VIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = VIN;
            this.HorsePower = horsePower;
            this.FuelAvailable = fuelAvailable;
            this.FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        public double FuelConsumptionPerRace
        {
            get { return fuelConsumptionPerRace; }
            set { FuelConsumtpionPerRaceValidation(value); }
        }

        public double FuelAvailable
        {
            get { return fuelAvailable; }
            set { FuelAvailableValidation(value); }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { HorsePowerValidation(value); }
        }

        public string VIN
        {
            get { return vin; }
            set { VinValidation(value); }
        }

        public string Model
        {
            get { return model; }
            set { ModelValidation(value); }
        }

        public string Make
        {
            get { return make; }
            set { MakeValidation(value); }
        }

        public virtual void Drive() => this.FuelAvailable = Math.Round(fuelAvailable - fuelConsumptionPerRace);

        private void MakeValidation(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Car make cannot be null or empty.");
            this.make = make;
        }

        private void ModelValidation(string model)
        {
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Car model cannot be null or empty.");
            this.model = model;
        }

        private void VinValidation(string vin)
        {
            if (vin.Length != 17)
                throw new ArgumentException("Car VIN must be exactly 17 characters long.");

            HashSet<char> characters = new HashSet<char>(vin);
            if (characters.Count != 17)
                throw new ArgumentException("All VINs will be unique.");

            this.vin = vin;
        }

        private void HorsePowerValidation(int horsePower)
        {
            if (horsePower < 0)
                throw new ArgumentException("Horse power cannot be below 0.");
            this.horsePower = horsePower;
        }

        private void FuelAvailableValidation(double fuelAvailable)
        {
            if (fuelAvailable < 0)
                this.fuelAvailable = 0;
            this.fuelAvailable = fuelAvailable;
        }

        private void FuelConsumtpionPerRaceValidation(double fuelConsumtpionPerRace)
        {
            if (fuelConsumtpionPerRace < 0)
                throw new ArgumentException("Fuel consumption cannot be below 0.");
            this.fuelConsumptionPerRace = fuelConsumtpionPerRace;
        }
    }
}