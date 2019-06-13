using System.Linq;
using System.Threading.Tasks;

namespace Bogota_Robotics_Company.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int? id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAysnc(T entity);
        Task<bool> ExistAsync(int id);
    }
}
