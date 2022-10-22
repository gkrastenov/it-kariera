using PreparationForExam4.Interfaces;
using PreparationForExam4.Models.People;
using PreparationForExam4.Models.Villages;
using System.Text;

namespace PreparationForExam4
{
    public class Controller : IController
    {
        private ICollection<IVillage> _villages;
        private ICollection<IRebel> _rebals;
        private int attackCommandCount;

        public Controller()
        {
            _villages = new List<IVillage>();
            _rebals = new List<IRebel>();
            attackCommandCount = 0;
        }

        public string ProceseVillageCommand(List<string> arguments)
        {
            // get arguments
            string villageName = arguments[0];
            string villageLocation = arguments[1];

            // create instance of Village
            Village village =  new Village(villageName, villageLocation);
            _villages.Add(village);

            return $"Created Village {villageName}!";
        }

        public string ProcessSettleCommand(List<string> arguments)
        {
            // get arguments
            string peasantName = arguments[0];
            int peasantAge = int.Parse(arguments[1]);
            int peasantProductivity = int.Parse(arguments[2]);
            string villageName = arguments[3];

            // create instance of Peasant 
            Peasant peasant = new Peasant(peasantName, peasantAge, peasantProductivity);

            var foundedVillage = FindVillageByName(villageName);
            foundedVillage.AddPeasant(peasant);

            return $"Settled Peasant {peasantName} in Village {villageName}!";
        }

        public string ProcessRebelCommand(List<string> arguments)
        {
            // get arguments
            string rebalName = arguments[0];
            int rebalAge = int.Parse(arguments[1]);
            int rebalHarm = int.Parse(arguments[2]);

            // create instance of Peasant 
            Rebel rebel = new Rebel(rebalName, rebalAge, rebalHarm);
            _rebals.Add(rebel);

            return $"Rebel {rebalName} joined the gang!";
        }

        public string ProcessDayCommand(List<string> arguments)
        {
            // get arguments
            string villageName = arguments[0];

            var foundedVillage = FindVillageByName(villageName);
            var dailyResource = foundedVillage.PassDay();

            return $"Village {villageName} resource increased with {dailyResource}!";
        }

        public string ProcessAttackCommand(List<string> arguments)
        {
            // get arguments
            int rebelCount = int.Parse(arguments[0]);
            string villageName = arguments[1];

            if (_rebals.Count == 0)
                return "No rebels to perform raid...";

            var rebels = _rebals.Take(rebelCount).ToList(); // take first N rebals
            var takenResource = rebels.Sum(r => r.Harm);

            var foundedVillage = FindVillageByName(villageName);
            foundedVillage.Resource -= takenResource;

            int deadPeasants = rebels.Count / 2;
            foundedVillage.KillPeasants(deadPeasants);

            attackCommandCount++;
            return $"Village {villageName} lost {takenResource} resources and {deadPeasants} peasants!";
        }

        public string ProcessInfoCommand(List<string> arguments)
        {
            StringBuilder sb = new StringBuilder();
            
            string side = arguments[0];
            if(side == "Rebel")
            {
                if (_rebals.Count == 0)
                    return "No Rebels";

                sb.AppendLine("Rebels:");
                foreach (var currentRebal in _rebals)
                    sb.AppendLine(currentRebal.ToString());          
            }

            if(side == "Village")
            {
                if (_villages.Count == 0)
                    return "No Villages";

                sb.AppendLine("Villages:");
                foreach (var currentVillage in _villages)
                    sb.AppendLine(currentVillage.ToString());
            }

            return sb.ToString();
        }

        public string ProcessEndCommand()
        {
            return $"Villages: {_villages.Count}" + Environment.NewLine
                + $"Rebels: {_rebals.Count}" + Environment.NewLine
                + $"Attacks on Villages: {attackCommandCount}";
        }

        private IVillage FindVillageByName(string villageName)
        {
            return _villages.FirstOrDefault(village => village.Name == villageName);
        }
    }
}