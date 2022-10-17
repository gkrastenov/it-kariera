namespace OOPExam3.Athletes.Interfaces
{
    public interface IAthlete
    {
        public int NumberOfMedals { get; set; }

        public int Stamina { get; set; }

        public string Motivation { get; set; }

        public string FullName { get; set; }

        public abstract void Exercise();
    }
}
