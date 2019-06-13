using Bogota_Robotics_Company.Data.Entities;

namespace Bogota_Robotics_Company.Data.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(DataContext context) : base(context)
        {

        }
    }
}
