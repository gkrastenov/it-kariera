using OOPExam3.Equipments.Interfaces;

namespace OOPExam3
{
    public class EquipmentRepository
    {
        private List<IEquipment> models;

        public IReadOnlyCollection<IEquipment> Models
        {
            get { return models; }
        }

        public void Add(IEquipment equipment)
        {
            models.Add(equipment);
        }

        public bool Remove(IEquipment equipment)
        {
            bool isFounded = models.Any(eq => eq == equipment);
            if(isFounded)
                models.Remove(equipment);
            return isFounded;
        }

        public IEquipment FindByType(string equipmentType)
        {
            return models.FirstOrDefault(eq => eq.GetType().ToString() == equipmentType);
        }
    }
}