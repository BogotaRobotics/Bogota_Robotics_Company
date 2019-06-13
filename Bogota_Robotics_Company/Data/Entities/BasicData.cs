using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bogota_Robotics_Company.Data.Entities
{
    public class BasicData
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateStarted { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string DetailedDescription { get; set; }
    }
}
