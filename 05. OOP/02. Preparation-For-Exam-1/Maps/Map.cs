using CarRacing.Models.Racers.Contracts;

namespace CarRacing.Models.Maps
{
    public class Map
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if(!racerOne.IsAvailable() && !racerTwo.IsAvailable())
                return "Race cannot be completed because both racers are not available!";

            if (!racerOne.IsAvailable())
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";

            if (!racerTwo.IsAvailable())
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";

            racerOne.Car.Drive();
            racerTwo.Car.Drive();

            double racingBehaviorMultiplier = 0;

            if (racerOne.RacingBehavior == "strict")
                racingBehaviorMultiplier = 1.2;
            else racingBehaviorMultiplier = 1.1;

            var chanceOfWinningOfFirst = racerOne.Car.HorsePower * racerOne.DrivingExperience * racingBehaviorMultiplier;

            if (racerTwo.RacingBehavior == "strict")
                racingBehaviorMultiplier = 1.2;
            else racingBehaviorMultiplier = 1.1;

            var chanceOfWinningOfSecond = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racingBehaviorMultiplier;

            if(chanceOfWinningOfFirst > chanceOfWinningOfSecond)
            {
                // racer one is winner
                return $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerOne.Username} is the winner!";
            }
            else
            {
                // racer tow is winner
                return $"{racerTwo.Username} has just raced against {racerOne.Username}! {racerTwo.Username} is the winner!";

            }
        }
    }
}