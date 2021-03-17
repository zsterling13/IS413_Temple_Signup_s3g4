using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//adding a time slot object to the database. And then the dateTime can go and be changed to individual parts of the date. 
namespace IS413_Temple_Signup_ZS.Models
{
    public class timeSlot
    {
        [Key, Required]
        public int slotID { get; set; }

        [Required]
        public DateTime scheduleInfo { get; set; }

        //Used to show whether the time slot is available for someone else to book at that time
        [Required]
        public bool availablility { get; set; } = true;

    }
}
