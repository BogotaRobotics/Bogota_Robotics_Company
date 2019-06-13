using Bogota_Robotics_Company.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bogota_Robotics_Company.Data.Repositories
{
    public interface IExperience
    {
        IEnumerable<Experience> GetAll();
        void Save(Experience experience);
        void Delete(Experience experience);
        void Update(Experience experience);
        Task SaveAllAsync();
    }
}
