using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Models
{
    public class timeSlot
    {
        [Key, Required]
        public int slotID { get; set; }

        [Required]
        public DateTime scheduleInfo { get; set; }

        [Required]
        public Boolean availablility { get; set; } = true;

    }
}
