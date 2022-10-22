namespace PreparationForExam4.Interfaces
{
    public interface IController
    {
        public string ProceseVillageCommand(List<string> arguments);

        public string ProcessSettleCommand(List<string> arguments);

        public string ProcessRebelCommand(List<string> arguments);

        public string ProcessDayCommand(List<string> arguments);

        public string ProcessAttackCommand(List<string> arguments);

        public string ProcessInfoCommand(List<string> arguments);

        public string ProcessEndCommand();
    }
}