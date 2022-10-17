using OOPExam3.Equipments.Interfaces;

namespace OOPExam3.Equipments
{
    public abstract class Equipment : IEquipment
    {
        private double weight;
        private decimal price;

        public Equipment(double weight, decimal price)
        {
            Weight = weight;
            Price = price;
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}