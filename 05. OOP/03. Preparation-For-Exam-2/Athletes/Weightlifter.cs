namespace OOPExam3.Athletes
{
    public class Weightlifter : Athlete
    {
        public Weightlifter(string fullName, string motivation, int numberOfMedals)
         : base(fullName, motivation, 50, numberOfMedals)
        {

        }

        public override void Exercise()
        {
            int increasedStamina = Stamina + 10;
            if (increasedStamina > 100)
            {
                Stamina = 100;
                throw new ArgumentException("Stamina can not exceed 100 points.");
            }
            Stamina = increasedStamina;
        }
    }
}
