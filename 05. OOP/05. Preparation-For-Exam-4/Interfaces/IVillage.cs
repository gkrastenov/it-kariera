using PreparationForExam4.Models.People;

namespace PreparationForExam4.Interfaces
{
    public interface IVillage
    {
        public int Resource { get; set; }

        public string Name { get;}

        void AddPeasant(Peasant peasant);

        int PassDay();

        List<Peasant> KillPeasants(int count);
    }
}