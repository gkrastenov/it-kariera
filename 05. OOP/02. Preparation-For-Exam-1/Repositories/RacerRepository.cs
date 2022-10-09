using CarRacing.Models.Racers;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<Racer>
    {
        private List<Racer> models;

        public IReadOnlyCollection<Racer> Models
        {
            get { return models; }
        }

        public void Add(Racer racer)
        {
            if (racer is null)
                throw new ArgumentException("Cannot add null in Racer Repository");
            models.Add(racer);
        }

        public Racer FindBy(string property)
        {
            return models.FirstOrDefault(r => r.Username == property);
        }

        public bool Remove(Racer model)
        {
            bool isFounded = models.Any(r => r == model);
            if (isFounded)
            {
                models.Remove(model);
                return true;
            }
            return false;
        }
    }
}