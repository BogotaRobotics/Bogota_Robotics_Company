using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogota_Robotics_Company.Models;

namespace Bogota_Robotics_Company.Services
{
    public class TestProfileService : IProfileService
    {
        public Task<List<Profile>> GetAsyncProfiles()
        {
            List<Profile> list = new List<Profile>
            {
                new Profile{Name="Karolina Ladino", Description="Whatever"},
                new Profile{Name="Karolina Ladino", Description="Whatever"},
                new Profile{Name="Karolina Ladino", Description="Whatever"}
            };
            return Task.FromResult(list);
        }
    }
}
