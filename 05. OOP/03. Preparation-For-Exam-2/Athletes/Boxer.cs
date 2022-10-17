namespace OOPExam3.Athletes
{
    public class Boxer : Athlete
    {
        public Boxer(string fullName, string motivation, int numberOfMedals)
            : base(fullName, motivation, 60, numberOfMedals)
        {

        }

        public override void Exercise()
        {
            int increasedStamina = Stamina + 15;
            if (increasedStamina > 100)
            {
                Stamina = 100;
                throw new ArgumentException("Stamina can not exceed 100 points.");
            }
            Stamina = increasedStamina;
        }
    }
}