using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bogota_Robotics_Company.Data.Entities
{
    public class Project:BasicData, IEntity
    {
        public int Id { get; set; }
        public string Repo { get; set; }
        public DateTime DateFinished { get; set; }
        public string Link { get; set; }
        public User User { get; set; }
    }
}
