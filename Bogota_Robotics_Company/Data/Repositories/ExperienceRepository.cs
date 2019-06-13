using Bogota_Robotics_Company.Data.Entities;

namespace Bogota_Robotics_Company.Data.Repositories
{
    public class ExperienceRepository : GenericRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(DataContext context) : base(context)
        {

        }
    }
}
