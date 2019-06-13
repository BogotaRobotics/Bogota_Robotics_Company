using Bogota_Robotics_Company.Data.Entities;

namespace Bogota_Robotics_Company.Data.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(DataContext context) : base(context)
        {

        }
    }
}
