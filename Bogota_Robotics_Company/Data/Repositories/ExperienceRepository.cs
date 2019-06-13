using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogota_Robotics_Company.Data.Entities;

namespace Bogota_Robotics_Company.Data.Repositories
{
    public class ExperienceRepository:IExperience
    {
        private readonly DataContext Data;

        public ExperienceRepository(DataContext data)
        {
            this.Data = data;
        }

        public void Delete(Experience experience)
        {
            this.Data.Remove(experience);
        }

        public IEnumerable<Experience> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Save(Experience experience)
        {
            throw new NotImplementedException();
        }

        public void Update(Experience experience)
        {
            throw new NotImplementedException();
        }
    }
}
