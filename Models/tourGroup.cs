using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Models
{
    public class tourGroup
    {
        [Key, Required]
        public int groupID { get; set; }

        [Required]
        public string groupName { get; set; }

        [Required]
        public int groupSize { get; set; }

        [Required, EmailAddress]
        public string emailAddress { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}")]
        public string phoneNumber { get; set; }

        public string tourTime { get; set; }
    }
}
