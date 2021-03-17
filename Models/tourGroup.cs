using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//tourGroup table for the database. Making the GroupId the key and setting the things to required, except for the phone, 
//and then adding the TourTime once it is pressed.

namespace IS413_Temple_Signup_ZS.Models
{
    public class tourGroup
    {
        [Key, Required]
        public int groupID { get; set; }

        [Required(ErrorMessage = "Group Name is required")]
        public string groupName { get; set; }

        [Required(ErrorMessage = "woops") , Range(1, 100, ErrorMessage = "Please enter a valid integer (1,2,3,4, etc.) between 1 and 100 for the group size. It is required")]
        public int groupSize { get; set; }

        [Required(ErrorMessage = "Email Address is required"), EmailAddress(ErrorMessage = "Not a valid email address")]
        public string emailAddress { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "Please enter the phone number in ###-###-#### format")]
        public string phoneNumber { get; set; }

        //String property that displays all of the dateTime properties that are assigned to it
        public string tourTime { get; set; }
    }
}
