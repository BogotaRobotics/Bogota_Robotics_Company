using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bogota_Robotics_Company.Models
{
    public class Profile:BasicData
    {
        //General Information
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Tastes { get; set; }
        //Social Media
        public string Github { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        //Professional Life
        public List<Project> Projects { get; set; }
        public List<Experience> Experiences { get; set; }

    }
}
