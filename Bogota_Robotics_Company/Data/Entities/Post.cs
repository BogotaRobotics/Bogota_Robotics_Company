using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bogota_Robotics_Company.Data.Entities
{
    public class Post:BasicData
    {
        public User User { get; set; }
    }
}
