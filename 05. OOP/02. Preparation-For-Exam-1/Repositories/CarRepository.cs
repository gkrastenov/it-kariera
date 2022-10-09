using CarRacing.Models.Cars;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        private List<Car> models;

        public IReadOnlyCollection<Car> Models
        {
            get { return models; }
        }

        public void Add(Car car)
        {
            if(car is null)
                throw new ArgumentException("Cannot add null in Car Repository");
            models.Add(car);
        }

        public Car FindBy(string property)
        {
            return models.FirstOrDefault(c => c.VIN == property);
        }

        public bool Remove(Car model)
        {
            bool isFounded = models.Any(c => c == model);
            if (isFounded)
            {
                models.Remove(model);
                return true;
            }
            return false;
        }
    }
}