using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    { 
        private string username;
        private string racingBehavior;
        private int drivingExperience;
        private ICar car;

        public Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            this.Username = username;
            this.RacingBehavior = racingBehavior;
            this.DrivingExperience = drivingExperience;
            this.Car = car;
        }
        public ICar Car
        {
            get { return car; }
            set { CarValidation(value); }
        }

        public int DrivingExperience
        {
            get { return drivingExperience; }
            set { DrivingExperienceValidation(value); }
        }

        public string RacingBehavior
        {
            get { return racingBehavior; }
            set { RacingBehaviorValidation(value); }
        }

        public string Username
        {
            get { return username; }
            set { UsernameValidation(value); }
        }

        public abstract void Race();

        public bool IsAvailable() => this.car.FuelAvailable > 0 ? true : false;

        private void UsernameValidation(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty.");
            this.username = username;
        }

        private void RacingBehaviorValidation(string racingBehavior)
        {
            if (string.IsNullOrWhiteSpace(racingBehavior))
                throw new ArgumentException("Racing behavior cannot be null or empty.");
            this.racingBehavior = racingBehavior;
        }

        private void DrivingExperienceValidation(int drivingExperience)
        {
            if (drivingExperience < 0 || drivingExperience > 100)
                throw new ArgumentException("Racer driving experience must be between 0 and 100.");
            this.drivingExperience = drivingExperience;
        }

        private void CarValidation(ICar car)
        {
            if (car is null)
                throw new ArgumentException("Car cannot be null or empty.");
            this.car = car;     
        }

    }
}