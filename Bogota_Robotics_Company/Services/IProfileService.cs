using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogota_Robotics_Company.Models;

namespace Bogota_Robotics_Company.Services
{
    public interface IProfileService
    {
        Task<List<Profile>> GetAsyncProfiles();
    }
}
