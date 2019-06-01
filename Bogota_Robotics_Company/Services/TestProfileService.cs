using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogota_Robotics_Company.Models;

namespace Bogota_Robotics_Company.Services
{
    public class TestProfileService : IProfileService
    {
        public TestProfileService()
        {
            listProfiles = new List<Profile>
            {
                new Profile{Name="Karolina Ladino", Description="Whatever"},
                new Profile{Name="Karolina Ladino", Description="Whatever"},
                new Profile{Name="Karolina Ladino", Description="Whatever"}
            };
        }
        private List<Profile> listProfiles { get; set; }
        public Task<List<Profile>> GetAsyncProfiles()
        {
           
            return Task.FromResult(listProfiles);
        }

        public Task<Profile> GetProfile(string name)
        {
            var x = listProfiles.Where(q => q.Name == name).FirstOrDefault();
            return Task.FromResult(x);
        }
    }
}
